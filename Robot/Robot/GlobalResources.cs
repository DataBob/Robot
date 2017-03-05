/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 4:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using SimpleLogger;
using SimpleLogger.Logging.Handlers;
using SimpleLogger.Logging.Module;

namespace Robot
{
	/// <summary>
	/// Description of GlobalResources.
	/// </summary>
	public class GR : IDisposable
	{
		private static GR _inst;
		
		public static GR Instance
	    {
	        get
	        {
	            return _inst;
	        }
	    }
		
		public readonly SerialPortConnection BalanceSerialPort;
		
		public readonly OutputManagement OutputCtrl;
		
		public readonly RecipesDB IngBD;
		
		public GR()
		{
			Logger.LoggerHandlerManager
            .AddHandler(new ConsoleLoggerHandler())
            .AddHandler(new FileLoggerHandler("RobotLogsFiles", true))
				.AddHandler(new DebugConsoleLoggerHandler());
			
//			Logger.Log("test log");
			
			BalanceSerialPort =  new SerialPortConnection();
			OutputCtrl = new OutputManagement();
			IngBD = new RecipesDB();
		}
		
		public static void Initialize()
		{
			if(_inst != null)
				throw new Exception("GlobalResources already initialized");
			_inst = new GR();
		}
		
		public void Dispose()
		{
			OutputCtrl.Dispose();
			BalanceSerialPort.Dispose();	
			IngBD.Dispose();
		}
		
		
		
		
	}
}
