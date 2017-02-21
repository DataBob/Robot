/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 4:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{	
	
	
	/// <summary>
	/// Description of CtrlGroupSelect.
	/// </summary>
	public partial class CtrlGroupSelect : UserControl
	{	
		public int SelectedGroup { get; private set; }
		
		public event EventHandler<CtrlGroupSelectEventArgs> GroupChangeOccurred;
		
		public CtrlGroupSelect()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			radioButton1.Select();
			SelectedGroup = 1;
		}	

	    protected virtual void OnGroupChangeOccurred()
	    {
	    	var grpInfos = new CtrlGroupSelectEventArgs() { _selectedGrp = SelectedGroup };
	        GroupChangeOccurred.Raise(this, grpInfos);
	    }
		
		void RadioButtonEnter(object sender, EventArgs e)
		{
			radioButton1.BackColor = Color.White;
			radioButton2.BackColor = Color.White;
			radioButton3.BackColor = Color.White;
			radioButton4.BackColor = Color.White;
			radioButton5.BackColor = Color.White;
			radioButton6.BackColor = Color.White;
			radioButton7.BackColor = Color.White;
			radioButton8.BackColor = Color.White;
			
			var btn = (RadioButton)sender;
			btn.BackColor = Color.LightBlue;
			
			SelectedGroup = int.Parse(btn.Text);
			
			OnGroupChangeOccurred();
		}
	}
	
	public class CtrlGroupSelectEventArgs : EventArgs
	{
	    public int _selectedGrp { get; set; }
	}
}
