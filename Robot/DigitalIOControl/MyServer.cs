using System;
using NamedPipeWrapper;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;
using SimpleLogger;
using MccDaq;

namespace DigitalIOControl
{
    class MyServer
    {
    	readonly NamedPipeServer<MessageContainer> _server;

		readonly CancellationTokenSource _cancelToken;
		
		readonly OutputManagement _outputManagement;
    	
    	BlockingCollection<MessageContainer> _messageQueue = new BlockingCollection<MessageContainer>();
    	
    	public bool ServerStarted { get; private set; }
    	
    	public bool ClientConnected  { get; private set; }

        public MyServer(string pipeName, CancellationTokenSource cancelToken)
        {
        	_cancelToken = cancelToken;
        	_outputManagement = new OutputManagement();
        	
        	if(_outputManagement.BoardFound == true)
        	{
	            _server = new NamedPipeServer<MessageContainer>(pipeName);
	            _server.ClientConnected += OnClientConnected;
	            _server.ClientDisconnected += OnClientDisconnected;
	            _server.ClientMessage += OnClientMessage;
	            _server.Error += OnError;
	            _server.Start();   
	            ServerStarted = true;
        	}
        	else
        	{
        		Logger.Log("Board not found");
        	}
        }
        
        public void WaitAndProcessEvents()
        {
        	//first time wait long enough for the program to be ready
        	int waitTimeMs = 10000;
        	bool keepRunning = true;
            while (keepRunning)
            {
				MessageContainer message;
				bool signaled = _messageQueue.TryTake(out message, waitTimeMs);
            	if(signaled)
            	{
            		var errorCode = ProcessOneEvent(message);
            		ProcessErrorAndResponse(errorCode, message);
            		//normal waiting time for ack
            		waitTimeMs = 3000;
            	}
            	else
            	{
            		//timeout, didn't receive ack
            		keepRunning = false;
            		Logger.Log("Didn't receive ack signal in time");
            	}
            }
//            _server.Stop();
        }
        
        private void ProcessErrorAndResponse(ErrorInfo.ErrorCode errorCode, MessageContainer message)
        {
        	if (ClientConnected)
        	{
        		var response = new MsgResponse { ErrorCode = errorCode, Message = message.Message };
        		_server.PushMessage(new MessageContainer(response));
        	}
        	if(errorCode != ErrorInfo.ErrorCode.NoErrors)
        	{
        		for (int i = 0; i < 5; i++) 
        		{
        			var err = _outputManagement.SetAllOff();
        			if (err == ErrorInfo.ErrorCode.NoErrors) 
        			{
        				break;
        			}
        			System.Threading.Thread.Sleep(200);
        		}
        		Logger.Log("ProcessErrorAndResponse: " + errorCode.ToString());
        		System.Threading.Thread.Sleep(2000);
        		Environment.Exit(1);	
        	}
        }
        
        private ErrorInfo.ErrorCode ProcessOneEvent(MessageContainer message)
        {
        	ErrorInfo.ErrorCode errorCode = ErrorInfo.ErrorCode.NoErrors;
        	if(message == null || message.Message == null)
        	{
        		errorCode = _outputManagement.SetAllOff();
        		Logger.Log("message null");
        		Thread.Sleep(1000);
        		Environment.Exit(1);
        	}
        	else if(message.Message is MsgSingleOuput)
        	{
        		var msg = message.Message as MsgSingleOuput;
        		errorCode = _outputManagement.Set(msg.DigiPortType, msg.OutputID, msg.DigiLogicState);
        	}
        	else if(message.Message is MsgTurnAllOff)
        	{
        		errorCode= _outputManagement.SetAllOff();
        	}
        	else if(message.Message is MsgExit)
        	{
        		errorCode = _outputManagement.SetAllOff();
        		Thread.Sleep(1000);
        		Environment.Exit(0);
        	}
        	return errorCode;
        }
        

        private void OnClientConnected(NamedPipeConnection<MessageContainer, MessageContainer> connection)
        {
        	ClientConnected = true;
            Console.WriteLine("Client {0} is now connected!", connection.Id);
        }

        private void OnClientDisconnected(NamedPipeConnection<MessageContainer, MessageContainer> connection)
        {
        	ClientConnected = false;
            Console.WriteLine("Client {0} disconnected", connection.Id);
            _messageQueue.Add(new MessageContainer(new MsgExit()));
        }

        private void OnClientMessage(NamedPipeConnection<MessageContainer, MessageContainer> connection, MessageContainer message)
        {
//            Console.WriteLine("Client {0} says: {1}", connection.Id, message);
            _messageQueue.Add(message);
        }

        private void OnError(Exception exception)
        {
        	Logger.Log("OnError", exception);
        }
        
    }
}