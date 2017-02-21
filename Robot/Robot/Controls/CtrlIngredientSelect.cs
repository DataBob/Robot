/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 12:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
	public class CtrlIngredientSelectEventArgs : EventArgs
	{
	    public int _selectedGrp { get; set; }
	}
	
	/// <summary>
	/// Description of CtrlIngredientSelect.
	/// </summary>
	public partial class CtrlIngredientSelect : UserControl
	{
		public int SelectedIngredient { get; private set; }
		
		public event EventHandler<CtrlIngredientSelectEventArgs> IngredientChangeOccurred;
		
		public CtrlIngredientSelect()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			radioButton1.Select();
		}
		
		protected virtual void OnIngredientChangeOccurred()
	    {
	    	var grpInfos = new CtrlIngredientSelectEventArgs() { _selectedGrp = SelectedIngredient };
	        EventHandler<CtrlIngredientSelectEventArgs> handler = IngredientChangeOccurred;
	        handler.Raise(this, grpInfos);
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
			
			var btn = (RadioButton)sender;
			btn.BackColor = Color.LightBlue;
			
			SelectedIngredient = int.Parse(btn.Text);
			OnIngredientChangeOccurred();
		}
		
		public void SelectIngredient(int ingredientID)
		{
			switch (ingredientID) {
				case 1:
					radioButton1.Select();
					break;
				case 2:
					radioButton2.Select();
					break;
				case 3:
					radioButton3.Select();
					break;
				case 4:
					radioButton4.Select();
					break;
				case 5:
					radioButton5.Select();
					break;
				case 6:
					radioButton6.Select();
					break;
				case 7:
					radioButton7.Select();
					break;	
			}
		}

	}
}
