using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NamedPipeWrapper;
using DigitalIOControl;
using MccDaq;
using System.Diagnostics;

namespace Robot
{
	/// <summary>
	/// Description of IOCommunication.
	/// </summary>
	public class IOCommunication : IDisposable
	{
		readonly NamedPipeClient<MessageContainer> _client;
		System.Timers.Timer _ackTimer;
		bool _disposed = false;
		
		public IOCommunication() 
		{
//			Process.Start(@"..\..\..\DigitalIOControl\bin\Debug\DigitalIOControl.exe");
			ProcessStartInfo processStartInfo = new ProcessStartInfo(@"DigitalIOControl.exe");

			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				_client = TryOpenPipe();
				_ackTimer = new System.Timers.Timer(500);
    			_ackTimer.Elapsed += (sender, e) => { SendAck(this); };
    			_ackTimer.Enabled = true;
			}
		}
		
		public void Dispose()
		{
			_disposed = true;
			_ackTimer.Stop();
			_ackTimer.Dispose();
			_ackTimer = null;
		}
		
		static void SendAck(IOCommunication ioCom)
	    {    	
			if(!ioCom._disposed)
			{
				ioCom._ackTimer.Stop();
				ioCom.SendPing();
				ioCom._ackTimer.Start();
			}
	    }
		
		private NamedPipeClient<MessageContainer> TryOpenPipe()
		{
			NamedPipeClient<MessageContainer> client = null;
			try
			{
				client = new NamedPipeClient<MessageContainer>("myPipe");
	            client.ServerMessage += OnServerMessage;
	            client.Error += OnError;
	            client.Start();
			}
			catch
			{
				//TODO
			}
			return client;
		}
		
		public void SendPing()
		{
			PushMessage(new DigitalIOControl.MsgPing());
		}
		
		public void SendExit()
		{
			PushMessage(new DigitalIOControl.MsgExit());
		}
		
		public void SendSetOneOutput(DigitalPortType port, int outputID, DigitalLogicState state)
		{
//			MessageContainer message;
			PushMessage(new MsgSingleOuput(port, outputID, state));
		}
		
		public void SendSetAllOff()
		{
			PushMessage(new MsgTurnAllOff());
		}
		
		private void PushMessage(MessageType messageType)
		{
			lock(this)
			{
				if(_client != null)
					_client.PushMessage(new MessageContainer(messageType)); 
			}
		}
		
		private void OnServerMessage(NamedPipeConnection<MessageContainer, MessageContainer> connection, MessageContainer message)
        {
            Console.WriteLine("Server says: {0}", message);
        }

        private void OnError(Exception exception)
        {
            Console.Error.WriteLine("ERROR: {0}", exception);
        }
	}
}
