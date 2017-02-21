/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 8:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of frmTestOutputs.
	/// </summary>
	public partial class frmTestOutputs : Form
	{
		public frmTestOutputs()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmTestOutputsFormClosing(object sender, FormClosingEventArgs e)
		{
			GR.Instance.OutputCtrl.SetAllIngredientOff();
		}
	}
}
