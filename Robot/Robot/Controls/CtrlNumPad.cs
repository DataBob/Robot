/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 8:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Robot
{
	/// <summary>
	/// Description of CtrlNumPad.
	/// </summary>
	public partial class CtrlNumPad : UserControl  // , IMessageFilter
	{
		public BtnClickDelegate BtnClickDel;
		
		private readonly SynchronizationContext synchronizationContext;
		
		public CtrlNumPad()
		{
			InitializeComponent();
			synchronizationContext = SynchronizationContext.Current;
			//Application.AddMessageFilter(this);
		}
		
//		public bool PreFilterMessage(ref Message m)
//    	{
//			const int WM_KEYDOWN = 0x0100;
//			
//			Keys[] keysToHandle = new Keys[] { Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Delete };
//			
//			var receivedKey = (Keys)m.WParam.ToInt32();
//			var keyFound = Array.Exists(keysToHandle, e => e.Equals(receivedKey));
//			
//			if(m.Msg.Equals(WM_KEYDOWN) && keyFound)
//			{
//				return true;
//		    }
//			return false;
//		}
		
		
		async void BtnNumMouseDown(object sender, MouseEventArgs e)
		{
			var ctrl = sender as Control;
			ctrl.Enabled = false;
			ctrl.BackColor = Color.LightBlue;
			
			SendCommand(ctrl.Text);
	
			await Task.Delay(200);
			ctrl.BackColor = Color.Gainsboro;
			ctrl.Enabled = true;
		}
		
		void SendCommand(string btnTxt)
		{
			int number;
			if(btnTxt.Equals("Del"))
			   BtnClickDel.RaiseDel(PadCommand.del);
			else if(int.TryParse(btnTxt, out number))
			{
				PadCommand cmd; 
				if(Enum.TryParse<PadCommand>("num" + number.ToString(), out cmd))
					BtnClickDel.RaiseDel(cmd);
			}
		}
		
		
		
		public void UpdateUI(Control btn)
		{		 
		    synchronizationContext.Post(new SendOrPostCallback(o =>
		    {
			    ((Control)o).BackColor = Color.Red;
		        BtnClickDel.RaiseDel(PadCommand.num7);
		    }), btn);
		 
		}	
	}
	
	public delegate void BtnClickDelegate(PadCommand keyParam); 
	
	public static class BtnClickDelegateExtensions
	{
		public static void RaiseDel(this BtnClickDelegate mDel, PadCommand keyParam)
		{
			if(mDel != null) mDel(keyParam);
				
		}
	}
	
	public enum PadCommand
	{
		num0,
		num1,
		num2,
		num3,
		num4,
		num5,
		num6,
		num7,
		num8,
		num9,
		del,
		back,
		dot,
	}
}
