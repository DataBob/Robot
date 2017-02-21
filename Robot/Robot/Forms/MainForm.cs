/*
 * Created by SharpDevelop.
 * User: User
 * Date: 4/2/2016
 * Time: 5:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;
using System.ComponentModel;



namespace Robot
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			
			MyConsole.SetMainForm(this);
			MyConsole.WriteLine("Open Console");
			InitializeComponent();	
			this.ResizeChildrenText();
			
			var frm = new frmChooseGroupStartAuto();
			frm.ShowDialog();		
		}
		
		
		
		
		
		void eWeightChange(WeightValue wv)
		{
			string strWeight = wv.FormatKg() + Environment.NewLine;		
//			this.InvokeIfRequired( c => { c.textBox1.Text += strWeight; } );		
		}	

		public void WriteLineTextBox(string line)
		{
//			this.InvokeIfRequired( c => { c.textBox1.Text += line + Environment.NewLine; } );	
		}
		
		void eShowfrmManualMode(object sender, EventArgs e)
		{
			var test = new frmManualMode();
			test.ShowDialog();
		}
		
		
		void eShowfrmEditRecipe(object sender, EventArgs e)
		{
			var frm = new frmEditRecipe();
			frm.ShowDialog();
		}
		void eShowfrmTestOutputs(object sender, EventArgs e)
		{
			var frm = new frmTestOutputs();
			frm.ShowDialog();
		}
		void eShowfrmAutomaticMode(object sender, EventArgs e)
		{
			var frm = new frmChooseGroupStartAuto();
			frm.ShowDialog();
		}
		void Label1Click(object sender, EventArgs e)
		{
			var lbl = sender as Label;
			if(lbl.BackColor == Color.Red)
				lbl.BackColor = Color.Blue;
			else
				lbl.BackColor = Color.Red;
		}
		void MainFormClientSizeChanged(object sender, EventArgs e)
		{
			this.ResizeChildrenText();
		}
		void BtnSerialPortClick(object sender, EventArgs e)
		{
			var frm = new frmSerialPort();
			frm.ShowDialog();
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			GR.Instance.OutputCtrl.SetAllIngredientOff();
		}
		
		
	}
}
