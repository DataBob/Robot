/*
 * Created by SharpDevelop.
 * User: User
 * Date: 4/2/2016
 * Time: 6:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Robot
{
	/// <summary>
	/// Description of EditRecipe.
	/// </summary>
	public partial class frmEditRecipe : Form
	{
		WeightValue _oldWeight = new WeightValue();
		WeightValue _newWeight = new WeightValue();
		WeightValue _ptrCurrentWeightDB;
		
		public frmEditRecipe()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ctrl2ValuesDisplay1.LblTitle1.Text = "Courante:";
			ctrl2ValuesDisplay1.LblTitle2.Text = "Nouvelle:";
			this.ResizeChildrenText();
			
			_oldWeight.WeightChangedDel += eOldWeightChange;
			_newWeight.WeightChangedDel += eNewWeightChange;
			ctrlNumPad.BtnClickDel += eNumPadClick;
			ctrlIngredientSelect.IngredientChangeOccurred += eIngredientSelectedChange;
			ctrlGroupSelect.GroupChangeOccurred += eGroupSelectedChange;
			LoadSelectedValue();
		}
		
		void eOldWeightChange(WeightValue wv)
		{
			//this.lblOldValue.Text = wv.FormatKg();
			ctrl2ValuesDisplay1.LblValue1.Text = wv.FormatKg();
		}
		
		void eNewWeightChange(WeightValue wv)
		{
			//this.lblNewValue.Text = wv.FormatKg();
			ctrl2ValuesDisplay1.LblValue2.Text = wv.FormatKg();
		}
		
		void eNumPadClick(PadCommand pCommand)
		{
			_newWeight.HandleKey(pCommand);
		}
		
		void eIngredientSelectedChange(object sender, CtrlIngredientSelectEventArgs e)
		{
			WriteToDBCurrentIngredient();
			LoadSelectedValue();
		}
		
		public delegate void InvokeDelegate();
		
		public void eGroupSelectedChange(object sender, CtrlGroupSelectEventArgs e)
		{
			WriteToDBCurrentIngredient();
			ctrlIngredientSelect.BeginInvoke(new InvokeDelegate(InvokeMethod));
			LoadSelectedValue();
		}
		
		public void InvokeMethod()
		{
		    ctrlIngredientSelect.SelectIngredient(1);
		}
		
		void LoadSelectedValue()
		{
			var groupID = ctrlGroupSelect.SelectedGroup;
			var ingredientID = ctrlIngredientSelect.SelectedIngredient;
			_ptrCurrentWeightDB = GR.Instance.IngBD.GetWeightValue(groupID, ingredientID);
			_oldWeight.Value = _ptrCurrentWeightDB.Value;
			_newWeight.Value = _oldWeight.Value;
		}
		
		void BtnQuitClick(object sender, EventArgs e)
		{
			this.Close();
			
		}
		void FrmEditRecipeFormClosing(object sender, FormClosingEventArgs e)
		{
			WriteToDBCurrentIngredient();
			GR.Instance.IngBD.SaveFile();
		}
		
		void WriteToDBCurrentIngredient()
		{
			_ptrCurrentWeightDB.Value = _newWeight.Value;
		}
		
//		IEnumerable<Control> GetAll(Control control,Type type)
//		{
//		    var controls = control.Controls.Cast<Control>();
//		
//		    return controls.SelectMany(ctrl => GetAll(ctrl,type))
//		                              .Concat(controls)
//		    	.Where(type.IsInstanceOfType);
//		}
//		
//		void ResizeChildrenText()
//		{
//			var ctrl = GetAll(this,typeof(ICtrlAutoResizable));
//			foreach (var element in ctrl) 
//			{
//				((ICtrlAutoResizable)element).ResizeControlText();
//			}
//		}
		

		void FrmEditRecipeClientSizeChanged(object sender, EventArgs e)
		{
			this.ResizeChildrenText();
		}
		
		
	}
}
