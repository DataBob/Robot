/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/9/2016
 * Time: 7:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Threading;
using SimpleLogger;
using SimpleLogger.Logging.Handlers;

namespace DigitalIOControl
{

	class Program
	{
		[DllImport("Kernel32")]
		private static extern bool SetConsoleCtrlHandler(EventHandler handler, bool add);
		
		private delegate bool EventHandler(CtrlType sig);
		static EventHandler _handler;
		
		
		static readonly CancellationTokenSource _cancelToken = new CancellationTokenSource();
		
		enum CtrlType
		{
		  CTRL_C_EVENT = 0,
		  CTRL_BREAK_EVENT = 1,
		  CTRL_CLOSE_EVENT = 2,
		  CTRL_LOGOFF_EVENT = 5,
		  CTRL_SHUTDOWN_EVENT = 6
		}
		
		private static bool Handler(CtrlType sig)
		{
			_cancelToken.Cancel();
			System.Threading.Thread.Sleep(5000);
			switch (sig)
			{
			  case CtrlType.CTRL_C_EVENT:
			  case CtrlType.CTRL_LOGOFF_EVENT:
			  case CtrlType.CTRL_SHUTDOWN_EVENT:
			  case CtrlType.CTRL_CLOSE_EVENT:
			  default:
			      return false;
			}
		}
		
		public static void Main(string[] args)
		{
			InitializeLogger();
			try
			{
				_handler += new EventHandler(Handler);
	  			SetConsoleCtrlHandler(_handler, true);
	  			var server = new MyServer("myPipe", _cancelToken);
	  			if(server.ServerStarted)
	  				server.WaitAndProcessEvents();
			}
			catch(Exception e)
			{
				Logger.Log(Logger.Level.Severe, e.Message + Environment.NewLine + e.StackTrace.ToString());
			}
		}
		
		public static void InitializeLogger()
		{
			Logger.LoggerHandlerManager
            .AddHandler(new ConsoleLoggerHandler())
            .AddHandler(new FileLoggerHandler("DigitalIOLogsFiles", true))
            .AddHandler(new DebugConsoleLoggerHandler());
		}
	}
}