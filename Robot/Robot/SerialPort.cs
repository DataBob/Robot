/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 7/12/2016
 * Time: 1:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;	
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Robot
{
	public delegate void ConnectionStatusChange(bool isConnected); //delegate type definition
	
	
	/// <summary>
	/// Description of SerialPort.
	/// </summary>
	public class SerialPortConnection : IDisposable
	{
		readonly SerialPort _serialPort = new SerialPort();
		bool _continue = true;
		private const int _baudRate = 1200; 
        private const int _dataBits = 8; 
        private Handshake _handshake = Handshake.None; 
        private Parity _parity = Parity.None; 
        private readonly string _portName; 
        private StopBits _stopBits = StopBits.One; 		
		
		Thread _readThread;
		readonly Stopwatch delayStopWatch = new Stopwatch();
		
		readonly System.Timers.Timer _portConnectedTimer;
		
		public bool _activeCallback;
		public ConnectionStatusChange _connectionStatusChange;
		
		public bool SerialPortActive { get; private set; }
	 
	    
	    public SerialPortConnection()
		{
	    	_activeCallback = true;
	    	_portName = GV.Instance.GetSerialPortCom();
    		var portNames = SerialPort.GetPortNames();
    		
    		var portExist = Array.Exists(portNames, x => x.Equals(_portName));
    		
    		foreach (var element in portNames) {
    			MyConsole.WriteLine(element);
    		}
    		
    		if(portExist)
    		{
    			ConfigureSerialPort(_serialPort, _portName);
	    		
		    	_serialPort.Open();
		    	
		    	
		    	delayStopWatch.Start();
		    	
		    	_readThread = new Thread(ReadSerialPortCallback);
		    	_readThread.Start();
    		}
    		else
    		{
    			MyConsole.WriteLine("Port Serie Introvable");
    			MyConsole.WriteLine("Port existants:");
    			foreach (var element in portNames) {
    				MyConsole.WriteLine(element);
    			}
    		}
    		_portConnectedTimer = new System.Timers.Timer(2000);
    		_portConnectedTimer.Elapsed += (sender, e) => { PortConnectedHandleElapsed(this); };
    		_portConnectedTimer.Enabled = true;
		}
	    
	    static void PortConnectedHandleElapsed(SerialPortConnection serialPort)
	    {    	
	    	serialPort.HandleChangeConnectionStatus(false);
	    }
	    
	    void HandleChangeConnectionStatus(bool isConnected)
	    {
	    	if(isConnected != SerialPortActive)
	    	{
	    		SerialPortActive = isConnected;
		    	if(_connectionStatusChange != null && _activeCallback)
		    	{
		    		_connectionStatusChange(isConnected);
	    		}
	    	}
	    }
	    
	    private void ConfigureSerialPort(SerialPort port, string portName)
	    {
	    	port.BaudRate = _baudRate; 
            port.DataBits = _dataBits; 
            port.Handshake = _handshake; 
            port.Parity = _parity; 
            port.PortName = portName;
            port.StopBits = _stopBits; 
//            port.ReadTimeout = SerialPort.InfiniteTimeout;
			port.ReadTimeout = 1000;
    		port.WriteTimeout = 500;
    		Console.WriteLine("ConfigureSerialPort: " + portName);
	    }
	    
	    
	    public void Dispose()
    	{
	     	_continue = false;
	     	Thread.Sleep(110);
	     	if(_readThread != null)
	    		_readThread.Join();
	     	if(_serialPort != null)
    			_serialPort.Close();
	    }
	    
	    
    
	    public void ReadSerialPortCallback()
		{
		    while (_continue)
		    {
		        try
		        {
		            string message = _serialPort.ReadLine();
		            if(_continue)
		            {        	
		            	if(message.Length >= 20)
		            	{
				            string weight = message.Substring(9,8);
				            weight = weight.Replace(" ", String.Empty);
				            int weightInt;
				            if(int.TryParse(weight, out weightInt))
				            {
				            	_portConnectedTimer.Stop();
				            	HandleChangeConnectionStatus(true);
				            	SerialPortActive = true;
				            	if(delayStopWatch.ElapsedMilliseconds > 500)
				            	{
				            		delayStopWatch.Stop();
				            		//TODO only update if necessary
	//			            		if(GV.Instance.TotalBalanceWeight.Value != weightInt)
					            	{
						            	GV.Instance.TotalBalanceWeight.Value = weightInt;
					            	}
				            		delayStopWatch.Restart();
				            	}
					            _portConnectedTimer.Start();
//					            SimpleLogger.Logger.Log(weight + Environment.NewLine);
				            }
			            }
		            }
		        }
		        //trick to use the timeout and get out of the ReadLine sometimes. Make closing the application easier.
		        catch (Exception e)
		        { 
//		        	SimpleLogger.Logger.Log("Serial port exception", e);
		        }
		    }
		} 
	}
}
