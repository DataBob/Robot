/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 7/18/2016
 * Time: 8:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of frmManualMode.
	/// </summary>
	public partial class frmManualMode : Form
	{
		public enum enumOperationStatus
		{
			Started,
			Stopped,
		}
		
		enumOperationStatus _operationStatus = enumOperationStatus.Stopped;
		
		readonly WeightValue _targetWeight = new WeightValue();
		readonly WeightValue _relativeBalanceWeight = new WeightValue();
		readonly WeightValue _referenceWeight = new WeightValue();
		
		public frmManualMode()
		{
			
			InitializeComponent();
			
			ctrl2ValuesDisplay1.LblTitle1.Text = "Cible:";
			ctrl2ValuesDisplay1.LblTitle1.MaxLength = ctrl2ValuesDisplay1.LblTitle1.Text.Length;
			ctrl2ValuesDisplay1.LblTitle2.Text = "Balance:";
			ctrl2ValuesDisplay1.LblTitle2.MaxLength = ctrl2ValuesDisplay1.LblTitle2.Text.Length;
			ctrl2ValuesDisplay1.LblValue1.MaxLength = "9999 KG".Length;
			ctrl2ValuesDisplay1.LblValue2.MaxLength = ctrl2ValuesDisplay1.LblValue1.MaxLength;
			_referenceWeight.Value = GV.Instance.TotalBalanceWeight.Value;
			
			GV.Instance.TotalBalanceWeight.WeightChangedDel  += eWeightChange;
			
			_targetWeight.WeightChangedDel += eTargetWeightChange;
			
			ctrlNumPad.BtnClickDel += eNumPadClick;
			
			_targetWeight.Value = 0;
		}
		
		void eWeightChange(WeightValue wv)
		{
			this.InvokeIfRequired( c => { 	
			                      	c.CompareBalanceAndTarget(wv);
			                      } );
		}
		
		void CompareBalanceAndTarget(WeightValue balanceWeight)
		{
			_relativeBalanceWeight.Value = balanceWeight.Value - _referenceWeight.Value;
			if(_relativeBalanceWeight.Value >= _targetWeight.Value)
			{
				StopIngredient();
			}
			SetBalanceValueDisplayed();
		}
		
		void eTargetWeightChange(WeightValue wv)
		{
			//display target value
			ctrl2ValuesDisplay1.LblValue1.Text = wv.FormatKg();
		}
		
		
		void StartIngredient()
		{
			btnStartStop.Text = "Stop";
			btnStartStop.BackColor = Color.Red;
			ctrlNumPad.Enabled = false;
			ctrlIngredientSelect1.Enabled = false;
			_referenceWeight.Value = GV.Instance.TotalBalanceWeight.Value;
			GR.Instance.OutputCtrl.SetIngredientOn(ctrlIngredientSelect1.SelectedIngredient);
			_operationStatus = enumOperationStatus.Started;
		}
		
		void StopIngredient()
		{
			GR.Instance.OutputCtrl.SetAllIngredientOff();
			btnStartStop.Text = "Start";
			btnStartStop.BackColor = Color.Lime;
			ctrlNumPad.Enabled = true;
			ctrlIngredientSelect1.Enabled = true;	
			_operationStatus = enumOperationStatus.Stopped;
		}
		
		void eNumPadClick(PadCommand pCommand)
		{
			_targetWeight.HandleKey(pCommand);
		}
		
		void BtnStartStopClick(object sender, EventArgs e)
		{
			this.InvokeIfRequired( c => { 	
			                      	c.ProcessStartStopButton();
			                      } );
			
		}
		
		void ProcessStartStopButton()
		{
			_referenceWeight.Value = GV.Instance.TotalBalanceWeight.Value;
			if(_operationStatus == enumOperationStatus.Stopped)
				StartIngredient();
			else
				StopIngredient();
		}
		
		void BtnQuitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void FrmManualModeFormClosing(object sender, FormClosingEventArgs e)
		{
			GV.Instance.TotalBalanceWeight.WeightChangedDel  -= eWeightChange;
			GR.Instance.OutputCtrl.SetAllIngredientOff();
		}
		
		void SetBalanceValueDisplayed()
		{
			//Set balance value
			ctrl2ValuesDisplay1.LblValue2.Text = _relativeBalanceWeight.FormatKg();
		}
		
		void CtrlIngredientSelect1IngredientChangeOccurred(object sender, CtrlIngredientSelectEventArgs e)
		{
			_referenceWeight.Value = GV.Instance.TotalBalanceWeight.Value;
			_targetWeight.Value = 0;
		}
	
	}
}
