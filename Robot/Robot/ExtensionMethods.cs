/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 10:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Robot
{
	/// <summary>
	/// Description of ExtensionMethods.
	/// </summary>
	public static class ExtensionMethods
	{
		public static void InvokeIfRequired(this MainForm mForm, Action<MainForm> action)
		{
		    if(mForm.InvokeRequired)
		    {
		    	try
		    	{
		       		mForm.Invoke(new Action(() => action(mForm)));
		    	}
		        catch ( ObjectDisposedException ) 
	        	{
			   	 // Ignore.  Control is disposed cannot update the UI.
			  	}
		    }
		    else
		    {
		        action(mForm);
		    }
		}
		
		public static void InvokeIfRequired(this CtrlFormConsole mForm, Action<CtrlFormConsole> action)
		{
		    if(mForm.InvokeRequired)
		    {
		    	try
		    	{
		       		mForm.Invoke(new Action(() => action(mForm)));
		    	}
		        catch ( ObjectDisposedException ) 
	        	{
			   	 // Ignore.  Control is disposed cannot update the UI.
			  	}
		    }
		    else
		    {
		        action(mForm);
		    }
		}
		
		public static void InvokeIfRequired(this frmManualMode mForm, Action<frmManualMode> action)
		{
		    if(mForm.InvokeRequired)
		    {
		    	try
		    	{
		       		mForm.Invoke(new Action(() => action(mForm)));
		    	}
		        catch ( ObjectDisposedException ) 
	        	{
			   	 // Ignore.  Control is disposed cannot update the UI.
			  	}
		    }
		    else
		    {
		        action(mForm);
		    }
		}
		
		public static void InvokeIfRequired(this frmAutomaticMode mForm, Action<frmAutomaticMode> action)
		{
		    if(mForm.InvokeRequired)
		    {
		    	try
		    	{
		       		mForm.Invoke(new Action(() => action(mForm)));
		    	}
		        catch ( ObjectDisposedException ) 
	        	{
			   	 // Ignore.  Control is disposed cannot update the UI.
			  	}
		    }
		    else
		    {
		        action(mForm);
		    }
		}
		
		public static void InvokeIfRequired(this frmWaitingTime mForm, Action<frmWaitingTime> action)
		{
		    if(mForm.InvokeRequired)
		    {
		    	try
		    	{
		       		mForm.Invoke(new Action(() => action(mForm)));
		    	}
		        catch ( ObjectDisposedException ) 
	        	{
			   	 // Ignore.  Control is disposed cannot update the UI.
			  	}
		    }
		    else
		    {
		        action(mForm);
		    }
		}
		
		public static void Raise(this EventHandler e, object sender)
		{
		    if(e != null)
		    {
		        e.Invoke(sender, EventArgs.Empty);
		    }
		}
		
		public static void Raise<TEventArgs>(
		    this EventHandler<TEventArgs> e,
		    object sender,
		    TEventArgs args)
		    where TEventArgs : EventArgs
		{
		    if(e != null)
		    {
		        e.Invoke(sender, args);
		    }
		}
		
		private static IEnumerable<Control> GetAll(Control control,Type type)
		{
		    var controls = control.Controls.Cast<Control>();
		
		    return controls.SelectMany(ctrl => GetAll(ctrl,type))
		                              .Concat(controls)
		    	.Where(type.IsInstanceOfType);
		}
		
		public static void ResizeChildrenText(this Control ctrlSrc)
		{
			var ctrl = GetAll(ctrlSrc,typeof(ICtrlAutoResizable));
			foreach (var element in ctrl) 
			{
				((ICtrlAutoResizable)element).ResizeControlText();
			}
		}
		
//		public static void ResizeControlText<T>(this T ctrl) where T : Control, ICtrlAutoResizable
//		{
//			string strMaxLength;
//			if(ctrl.MaxLength > 0)
//			{
//				strMaxLength = "".PadLeft(ctrl.MaxLength);
//			}
//			else
//			{
//				strMaxLength = ctrl.Text;
//			}
//			
//				 // If there's no text, return
//		    if (strMaxLength.Length == 0) return;
//		
//		    // Get height and width, we'll be using these repeatedly
//		    int height = ctrl.Height;
//		    int width = ctrl.Width;
//		
//		    // Suspend layout while we mess with stuff
//		    ctrl.SuspendLayout();
//		
//		    Font tryFont = ctrl.Font;
//		    Size tempSize = TextRenderer.MeasureText( strMaxLength, ctrl.Font);
//		
//		    // Make sure it isn't too small first
//		    while (tempSize.Height < height || tempSize.Width < width)
//		    {
//		        tryFont = new Font(tryFont.FontFamily, tryFont.Size + 0.1f, tryFont.Style);
//		        tempSize = TextRenderer.MeasureText(strMaxLength, tryFont);
//		    }
//		
//		    // Now make sure it isn't too big
//		    while (tempSize.Height > height || tempSize.Width > width)
//		    {
//		        tryFont = new Font(tryFont.FontFamily, tryFont.Size - 0.1f, tryFont.Style);
//		        tempSize = TextRenderer.MeasureText(strMaxLength, tryFont);
//		    }
//		
//		    // Swap the font
//		    ctrl.Font = tryFont;
//		
//		    // Resume layout
//		    ctrl.ResumeLayout();
//		}
	}
}
