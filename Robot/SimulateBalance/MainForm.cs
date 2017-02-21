/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 2/6/2017
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimulateBalance
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		SerialPortConnection _serialPort;

	    readonly Timer _refreshTimer;
	    
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			_serialPort = new SerialPortConnection();
			_refreshTimer = new Timer();
			_refreshTimer.Interval = 200;
			_refreshTimer.Tick += eTimerCallback;
			_refreshTimer.Start();
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			txtCurrent.Text = "0";
		}
		void BtnAddClick(object sender, EventArgs e)
		{
			var newVal = int.Parse(txtCurrent.Text) + int.Parse(txtAdd.Text);
			txtCurrent.Text = newVal.ToString();
		}
		
		void WriteToPort()
		{
			lock(_serialPort)
			{
				if(_serialPort != null)
					_serialPort.Write(txtCurrent.Text);
			}
		}
		void TxtCurrentTextChanged(object sender, EventArgs e)
		{
			WriteToPort();
		}
		
		private void eTimerCallback(object sender, EventArgs e)
	    {
	    	WriteToPort();
	    }
	}
}
