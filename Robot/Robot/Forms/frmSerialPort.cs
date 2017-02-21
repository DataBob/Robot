/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 1/21/2017
 * Time: 3:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of frmSerialPort.
	/// </summary>
	public partial class frmSerialPort : Form
	{
		
		public frmSerialPort()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string comPort = GV.Instance.GetSerialPortCom();
			this.cBoxComPort.SelectedIndex = cBoxComPort.FindStringExact(comPort);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CBoxComPortSelectedIndexChanged(object sender, EventArgs e)
		{
			GV.Instance.SetSerialPortCom(cBoxComPort.Text);
		}
	}
}
