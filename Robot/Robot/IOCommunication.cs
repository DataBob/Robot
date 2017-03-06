using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NamedPipeWrapper;
using DigitalIOControl;
using MccDaq;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of IOCommunication.
	/// </summary>
	public class IOCommunication : IDisposable
	{
		readonly NamedPipeClient<MessageContainer> _client;
		System.Windows.Forms.Timer _ackTimer;
		bool _disposed = false;
		
		BlockingCollection<MessageContainer> _receiveMsgQueue = new BlockingCollection<MessageContainer>();
		
		public IOCommunication() 
		{
//			Process.Start(@"..\..\..\DigitalIOControl\bin\Debug\DigitalIOControl.exe");
			ProcessStartInfo processStartInfo = new ProcessStartInfo(@"DigitalIOControl.exe");

			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				_client = TryOpenPipe();
				_ackTimer = new System.Windows.Forms.Timer();
				_ackTimer.Interval = 200;
    			_ackTimer.Tick += new EventHandler(timer_Tick); 
    			_ackTimer.Tag = this;
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
		
		void timer_Tick(object sender, EventArgs e)
	    {    	
			var timer = (System.Windows.Forms.Timer)sender;
			var ioCom = (IOCommunication)timer.Tag;
			if(!ioCom._disposed)
			{
				ioCom._ackTimer.Stop();
				ioCom.SendPing();
				ioCom.CheckReturnMessage();
				ioCom._ackTimer.Start();
			}
	    }
		
		private void CheckReturnMessage()
		{
			MessageContainer message;
			while(_receiveMsgQueue.TryTake(out message, 0))
			{
				if(message != null && message.Message !=null)
				{
					var retMsg = message.Message as MsgResponse;
					if(retMsg != null && retMsg.ErrorCode != ErrorInfo.ErrorCode.NoErrors)
					{
						//TODO better management
						SimpleLogger.Logger.Log("CheckReturnMessage: " + retMsg.ErrorCode.ToString());
					}
				}
			}	
		}
		
//		private async Task MessageError()
//		{
//			var cts = new CancellationTokenSource(); 
//			await Beep(cts.Token);
//			MessageBox.Show("Error");
//			cts.Cancel();
//		}
//		
//		private async Task Beep(CancellationToken ct)
//		{
//			while (!ct.IsCancellationRequested) 
//			{
//				await Task.Run(() => Console.Beep(5000,1000));
//			}
//		}
		
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
//            Console.WriteLine("Server says: {0}", message);
            _receiveMsgQueue.Add(message);
        }

        private void OnError(Exception exception)
        {
            Console.Error.WriteLine("ERROR: {0}", exception);
        }
	}
}
