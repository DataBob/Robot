/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 2/20/2017
 * Time: 1:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SimpleLogger.Logging;
using SimpleLogger;
using SimpleLogger.Logging.Handlers;
using SimpleLogger.Logging.Formatters;

namespace Robot
{
	/// <summary>
	/// Description of CtrlFormConsole.
	/// </summary>
	public partial class CtrlFormConsole : UserControl, ILoggerHandler
	{
		private readonly ILoggerFormatter _loggerFormatter;
		
		// This delegate enables asynchronous calls for setting  
		// the text property on a TextBox control.  
		delegate void StringArgReturningVoidDelegate(string text);  
		 
		public CtrlFormConsole()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Location = new System.Drawing.Point(3, 3);
			this.Name = "ctrlFormConsole1";
			_loggerFormatter = new DefaultLoggerFormatter();
			Logger.LoggerHandlerManager.AddHandler(this);
		}
		
		public void Publish(LogMessage logMessage)
        {
			try 
			{
//				if(!this.Disposed)
				{
					this.InvokeIfRequired( c => { this.textBox1.Text = logMessage.CallingMethod + ": " + logMessage.Text + Environment.NewLine + this.textBox1.Text; } );	
				}
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("eConnectionStatusChange",ex);
				throw;
			}
        }
		
		new public void Dispose()
		{
			Logger.LoggerHandlerManager.RemoveHandler(this);
			base.Dispose();
		}
	}
}
