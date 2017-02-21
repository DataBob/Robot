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
		
//		bool[] _outputsState = new bool[8];
		
		public bool BoardFound { get; private set; }
		
              
		public OutputManagement()
		{
			try
			{
	        	DaqBoard = new MccDaq.MccBoard(0);
	        	MccDaq.ErrorInfo ULStat;
	        	
	        	ULStat = MccDaq.MccService.ErrHandling(ErrorReporting.DontPrint, ErrorHandling.DontStop);
	        	PrintError(ULStat);
	        	 
	        	ULStat = DaqBoard.FlashLED();			
	            PrintError(ULStat);         
	        	
	            ULStat = DaqBoard.DConfigPort(DigitalPortType.FirstPortA, DigitalPortDirection.DigitalOut);
	            PrintError(ULStat);
	            if(ULStat.Value == ErrorInfo.ErrorCode.NoErrors)
	            {
	  				//It take sometimes for the output to be usable;      
	  				Console.WriteLine("Board found");
	             	Thread.Sleep(500);
	             	BoardFound= true;
	            }
			}
			catch(Exception e)
			{
				BoardFound = false;
				SimpleLogger.Logger.Log("Board not found",e);
			}
		}
		
		public void Set(DigitalPortType port, int outputID, DigitalLogicState state)
		{
			lock(this)
			{
				Console.WriteLine(String.Format("port: {0}, outputID: {1}, state: {2}", port, outputID, state));
				if(!BoardFound)
					return;
				if(port == DigitalPortType.FirstPortA && outputID >= 0 && outputID <= 7)
				{
					MccDaq.ErrorInfo ULStat;
					ULStat = DaqBoard.DBitOut(port, outputID, state);
					PrintError(ULStat);
				}
				else
				{
					SimpleLogger.Logger.Log("Port Not supported");
					Environment.Exit(0);
				}
			}
		}
		
//		private void TryOutputMultipeTimes(DigitalPortType port, int bitNum, DigitalLogicState state)
//		{
//			MccDaq.ErrorInfo ULStat;
//			ULStat = DaqBoard.DBitOut(port, outputID, state);
//			PrintError(ULStat);
//		}
		
		public void SetAllOff()
		{
			lock(this)
			{
				Console.WriteLine("SetAllOff");
				if(!BoardFound)
					return;
				MccDaq.ErrorInfo ULStat;
				ULStat = DaqBoard.DOut(DigitalPortType.FirstPortA, 0);
				PrintError(ULStat);
//				MccDaq.ErrorInfo ULStat;
//				for(int i = 0; i < 8; i++)
//				{		
//					ULStat = DaqBoard.OutByte(.DBitOut(DigitalPortType.FirstPortA, i, DigitalLogicState.Low);
//					PrintError(ULStat);
//					Thread.Sleep(50);
//				}
			}
		}
		

		private void PrintError(MccDaq.ErrorInfo ULStat)
		{
			if(ULStat.Value != 0)
				SimpleLogger.Logger.Log(ULStat.Message);
		}				
	}
}
