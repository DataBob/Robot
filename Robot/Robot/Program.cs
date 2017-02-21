/*
 * Created by SharpDevelop.
 * User: User
 * Date: 4/2/2016
 * Time: 5:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Robot
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{		
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{			
			if ( !AttachConsole(ATTACH_PARENT_PROCESS) )
			{ 
	           AllocConsole(); 
			}
			
			System.Threading.Thread.Sleep(2000);
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);	
			try
			{
				GR.Initialize();
				Application.Run(new MainForm());
			}
			catch(Exception ex)
			{
				SimpleLogger.Logger.Log(ex.StackTrace + Environment.NewLine + ex.Message);
				GR.Instance.OutputCtrl.SetAllIngredientOff();
			}
			finally
			{
				GR.Instance.Dispose();
			}
			
			
		}
		
		[DllImport("kernel32.dll")]
	    static extern bool AttachConsole(int dwProcessId);
	    private const int ATTACH_PARENT_PROCESS = -1;
	    
	    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    	private static extern bool AllocConsole();

	
	    [DllImport("kernel32.dll", SetLastError = true)]
	    internal static extern int FreeConsole();
		
	}
}
