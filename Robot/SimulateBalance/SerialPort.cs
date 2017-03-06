/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 2/7/2017
 * Time: 4:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Threading;	
using System.IO.Ports;
using System.Diagnostics;

namespace SimulateBalance
{
	public class SerialPortConnection : IDisposable
	{
		readonly SerialPort _serialPort = new SerialPort();
		bool _continue = true;
		private const int _baudRate = 1200; 
        private const int _dataBits = 8; 
        private Handshake _handshake = Handshake.None; 
        private Parity _parity = Parity.None; 
        private StopBits _stopBits = StopBits.One; 		
		
		readonly Stopwatch delayStopWatch = new Stopwatch();
		
	    
	    
	    int _testWeight = 0;
	    


	    public SerialPortConnection()
		{
			ConfigureSerialPort(_serialPort, "COM2");	
	    	_serialPort.Open();
		}
	    

	    
	    private void ConfigureSerialPort(SerialPort port, string portName)
	    {
	    	port.BaudRate = _baudRate; 
            port.DataBits = _dataBits; 
            port.Handshake = _handshake; 
            port.Parity = _parity; 
            port.PortName = portName;
            port.StopBits = _stopBits; 
            port.ReadTimeout = 500;
    		port.WriteTimeout = 500;
	    }
	    
	    
	    public void Dispose()
    	{
	     	_continue = false;
	     	Thread.Sleep(110);
	     	if(_serialPort != null)
    			_serialPort.Close();
	    }
	    
	    public void Write(string weight) 
	     {
	     	if(_continue)
	     	{
		     	_testWeight++;
		     	weight = weight.PadLeft(8);
		     	_serialPort.WriteLine("ST,GS,??," + weight + " kg");
		     	//_testTimer.Change(100, Timeout.Infinite);
	     	}
	     }
	    
	 
	}
}
