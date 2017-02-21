using System;
using NamedPipeWrapper;
using System.Threading;
using System.Collections.Generic;
using System.Collections.Concurrent;
using SimpleLogger;

namespace DigitalIOControl
{
    class MyServer
    {
    	readonly NamedPipeServer<MessageContainer> _server;

		readonly CancellationTokenSource _cancelToken;
		
		readonly OutputManagement _outputManagement;
    	
    	BlockingCollection<MessageContainer> _messageQueue = new BlockingCollection<MessageContainer>();
    	
    	public bool ServerStarted { get; private set; }

        public MyServer(string pipeName, CancellationTokenSource cancelToken)
        {
        	_cancelToken = cancelToken;
        	_outputManagement = new OutputManagement();
        	
//        	if(_outputManagement.BoardFound == true)
        	{
	            _server = new NamedPipeServer<MessageContainer>(pipeName);
	            _server.ClientConnected += OnClientConnected;
	            _server.ClientDisconnected += OnClientDisconnected;
	            _server.ClientMessage += OnClientMessage;
	            _server.Error += OnError;
	            _server.Start();   
	            ServerStarted = true;
        	}
        }
        
        public void WaitAndProcessEvents()
        {
        	bool keepRunning = true;
            while (keepRunning)
            {
				MessageContainer message;
				bool signaled = _messageQueue.TryTake(out message, 200000);
            	if(signaled)
            	{
            		ProcessOneEvent(message);
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
        
        private void ProcessOneEvent(MessageContainer message)
        {
        	if(message == null || message.Message == null)
        	{
        		Logger.Log("message null");
        	}
        	else if(message.Message is MsgSingleOuput)
        	{
        		ProcessSingleOutput(message.Message as MsgSingleOuput);
        	}
        	else if(message.Message is MsgTurnAllOff)
        	{
        		_outputManagement.SetAllOff();
        	}
        	else if(message.Message is MsgExit)
        	{
        		_outputManagement.SetAllOff();
        		Thread.Sleep(1000);
        		Environment.Exit(0);
        	}
        }
        
        private void ProcessSingleOutput(MsgSingleOuput message)
        {
        	_outputManagement.Set(message.DigiPortType, message.OutputID, message.DigiLogicState);
        }

        private void OnClientConnected(NamedPipeConnection<MessageContainer, MessageContainer> connection)
        {
            Console.WriteLine("Client {0} is now connected!", connection.Id);
        }

        private void OnClientDisconnected(NamedPipeConnection<MessageContainer, MessageContainer> connection)
        {
            Console.WriteLine("Client {0} disconnected", connection.Id);
            _messageQueue.Add(new MessageContainer(new MsgExit()));
        }

        private void OnClientMessage(NamedPipeConnection<MessageContainer, MessageContainer> connection, MessageContainer message)
        {
            Console.WriteLine("Client {0} says: {1}", connection.Id, message);
            _messageQueue.Add(message);
        }

        private void OnError(Exception exception)
        {
        	Logger.Log("OnError", exception);
        }
        
    }
}