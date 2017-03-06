/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 7/25/2016
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using MccDaq;

using System.Threading;


namespace DigitalIOControl
{
	
	/// <summary>
	/// Description of OutputManagement.
	/// </summary>
	public class OutputManagement
	{
		MccDaq.MccBoard DaqBoard;
		
		public bool BoardFound { get; private set; }
	
              
		public OutputManagement()
		{
			try
			{
				ErrorInfo.ErrorCode errorCode;
	        	DaqBoard = new MccDaq.MccBoard(0);
	        	MccDaq.ErrorInfo ULStat;
	        	
	        	ULStat = MccDaq.MccService.ErrHandling(ErrorReporting.DontPrint, ErrorHandling.DontStop);
	        	errorCode = PrintError(ULStat);
	        	 
	        	if(ErrorInfo.ErrorCode.NoErrors == PrintError(ULStat))
	        	{
		        	ULStat = DaqBoard.FlashLED();			    
	        	}
	        	
	        	if(ErrorInfo.ErrorCode.NoErrors == PrintError(ULStat))
	        	{
		            ULStat = DaqBoard.DConfigPort(DigitalPortType.FirstPortA, DigitalPortDirection.DigitalOut);
	        	}
	        	
	            if(ErrorInfo.ErrorCode.NoErrors == PrintError(ULStat))
	            {
	  				//It take sometimes for the output to be usable;      
	  				Console.WriteLine("Board found");
	             	Thread.Sleep(500);
	             	BoardFound= true;
	             	SetAllOff();
	            }
			}
			catch(Exception e)
			{
				BoardFound = false;
				SimpleLogger.Logger.Log("Board not found",e);
			}
		}
		
		public ErrorInfo.ErrorCode Set(DigitalPortType port, int outputID, DigitalLogicState state)
		{
			lock(this)
			{
				Console.WriteLine(String.Format("port: {0}, outputID: {1}, state: {2}", port, outputID, state));
				if(!BoardFound)
					return ErrorInfo.ErrorCode.BoardNotExist;
				if(port == DigitalPortType.FirstPortA && outputID >= 0 && outputID <= 7)
				{
					MccDaq.ErrorInfo ULStat;
					ULStat = DaqBoard.DBitOut(port, outputID, state);
					return PrintError(ULStat);
				}
				else
				{
					SimpleLogger.Logger.Log("Port Not supported");
					Environment.Exit(1);
					return ErrorInfo.ErrorCode.InvalidNetPort;
				}
			}
		}
		
		
		public ErrorInfo.ErrorCode SetAllOff()
		{
			lock(this)
			{
				Console.WriteLine("SetAllOff");
				if(!BoardFound)
					return ErrorInfo.ErrorCode.BoardNotExist;
				MccDaq.ErrorInfo ULStat;
				ULStat = DaqBoard.DOut(DigitalPortType.FirstPortA, 0);
				return PrintError(ULStat);
			}
		}
		

		private ErrorInfo.ErrorCode PrintError(MccDaq.ErrorInfo ULStat)
		{
			if(ULStat.Value != 0)
			{
				SimpleLogger.Logger.Log(ULStat.Message);   
			}
			return ULStat.Value;
		}				
	}
}
