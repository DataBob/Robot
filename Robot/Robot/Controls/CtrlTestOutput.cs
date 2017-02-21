/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 4:00 PM
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
	/// Description of CtrlTestOutput.
	/// </summary>
	public partial class CtrlTestOutput : UserControl
	{
		public CtrlTestOutput()
		{
			InitializeComponent();
			
			radioButtonOff.Select();
		}
		
		void RadioButtonEnter(object sender, EventArgs e)
		{
			radioButtonOff.BackColor = Color.White;
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
			
			GR.Instance.OutputCtrl.SetAllIngredientOff();
			int ingredientID;
			if(int.TryParse(btn.Text, out ingredientID))
			{
				GR.Instance.OutputCtrl.SetIngredientOn(ingredientID);
			}
		}

		public new void Dispose()
		{
			GR.Instance.OutputCtrl.SetAllIngredientOff();
			base.Dispose();
		}
	}
}
