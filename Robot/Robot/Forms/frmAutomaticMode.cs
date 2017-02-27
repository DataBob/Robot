/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/10/2016
 * Time: 12:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using SimpleLogger;
using System.Threading.Tasks;

namespace Robot
{
	/// <summary>
	/// Description of frmAutomaticMode.
	/// </summary>
	public partial class frmAutomaticMode : Form
	{
		readonly int _groupID;
		int _currentIngredient = 0;
		readonly WeightValue _targetWeight = new WeightValue();
		readonly WeightValue _relativeBalanceWeight = new WeightValue();
		readonly WeightValue _referenceWeight = new WeightValue();
		readonly System.Windows.Forms.Timer _timer;
		bool _IngredientIsActive = false;
		
		bool _serialPortConnected;
		
		public bool FillingCompleted { get; private set; }
		
		public frmAutomaticMode(int groupID)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();	
			
			_serialPortConnected = GR.Instance.BalanceSerialPort.SerialPortActive;
			
			ctrl2ValuesDisplay1.LblTitle1.Text = "Cible:";
			ctrl2ValuesDisplay1.LblTitle1.MaxLength = ctrl2ValuesDisplay1.LblTitle1.Text.Length;
			ctrl2ValuesDisplay1.LblTitle2.Text = "Balance:";
			ctrl2ValuesDisplay1.LblTitle2.MaxLength = ctrl2ValuesDisplay1.LblTitle2.Text.Length;
			ctrl2ValuesDisplay1.LblValue1.MaxLength = "9999 KG".Length;
			ctrl2ValuesDisplay1.LblValue2.MaxLength = ctrl2ValuesDisplay1.LblValue1.MaxLength;
			
			
			GV.Instance.TotalBalanceWeight.WeightChangedDel  += eTotalBalanceWeightChange;
			_targetWeight.WeightChangedDel += eTargetWeightChange;
			_relativeBalanceWeight.WeightChangedDel += eRelativeBalanceWeightChange;
			_referenceWeight.WeightChangedDel += eReferenceWeightChange;
			
			_referenceWeight.Value = GV.Instance.TotalBalanceWeight.Value;
			
			_groupID = groupID;
			
			this.ctrlLabelGroup.Text = "Groupe: " + _groupID.ToString();
			
			this.ResizeChildrenText();
			
			GR.Instance.BalanceSerialPort._connectionStatusChange += eConnectionStatusChange;
			
			_timer = new System.Windows.Forms.Timer();
			_timer.Tick += CheckAndStartNewIngredient;
			_timer.Interval = 4000;
			_timer.Start();	
		}
		
		void eConnectionStatusChange(bool isConnected)
		{
			//TODO
			try {
				this.InvokeIfRequired( c => { 
			                      	ProcessConnectionStatusChange(isConnected);
			                      } );
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("eConnectionStatusChange",ex);
				throw;
			}
		}
		
		void ProcessConnectionStatusChange(bool isConnected)
		{
			try {
				if(isConnected != _serialPortConnected)
				{
					if(isConnected)
					{
						this.lblSerialPortStatus.Text = "";
						this.lblSerialPortStatus.ForeColor = Color.Black;
						GR.Instance.OutputCtrl.SetIngredientOn(_currentIngredient);
					}
					else
					{
						GR.Instance.OutputCtrl.SetIngredientOff(_currentIngredient);
						this.lblSerialPortStatus.Text = "Serial port disconnected";
						this.lblSerialPortStatus.ForeColor = Color.Red;
					}
				}
				_serialPortConnected = isConnected;
			} 
			catch (Exception ex)
			{
				SimpleLogger.Logger.Log("ProcessConnectionStatusChange",ex);
				throw;
			}	
		}
		
		
		
		
		void CheckAndStartNewIngredient(object sender, EventArgs e)
		{
			try
			{
				_timer.Stop();
				if(NextIngredient())
				{
					StartCurrentIngredient();
					SimpleLogger.Logger.Log("_targetWeight.Value", _targetWeight.Value);
				}
				else
				{
					FillingCompleted = true;
					this.Close();
				}
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("CheckAndStartNewIngredient",ex);
				throw;
			}
		}
		
		bool NextIngredient()
		{
			try 
			{
				bool ingredientFound = false;
				for(int x = _currentIngredient + 1; x <= GV.NB_INGREDIENTS && !ingredientFound; x++)
				{
					var weight = GR.Instance.IngBD.GetWeightValue(_groupID, x);
					if(weight.Value > 0)
					{
						_currentIngredient = x;
						this.ctrlLabelIngredient.Text = "Ingrédient: " + _currentIngredient.ToString();
						_targetWeight.Value = weight.Value;
						ingredientFound = true;
					}
				}
				return ingredientFound;
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("NextIngredient",ex);
				throw;
			}
		}
		
		void StartCurrentIngredient()
		{
			try 
			{
				_referenceWeight.Value = GV.Instance.TotalBalanceWeight.Value;
				_IngredientIsActive = true;
				GR.Instance.OutputCtrl.SetIngredientOn(_currentIngredient);
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("StartCurrentIngredient",ex);
				throw;
			}
		}
		

		void eTotalBalanceWeightChange(WeightValue wv)
		{
			try 
			{
				this.InvokeIfRequired( c => { 
			                      	lblSerialPortStatus.Text = GV.Instance.TotalBalanceWeight.FormatKg();
			                      	c.ProcessBalanceWeightChange(wv);
			                      } );
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("eTotalBalanceWeightChange",ex);
				throw;
			}	
		}
		
		
		
		void ProcessBalanceWeightChange(WeightValue balanceWeight)
		{
			try 
			{
				_relativeBalanceWeight.Value = balanceWeight.Value - _referenceWeight.Value;
				
				if(_IngredientIsActive && _relativeBalanceWeight.Value >= _targetWeight.Value)
				{
					_IngredientIsActive = false;
					GR.Instance.OutputCtrl.SetIngredientOff(_currentIngredient);
					_timer.Start();					
				}
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("ProcessBalanceWeightChange",ex);
				throw;
			}
		}
		
		void eTargetWeightChange(WeightValue wv)
		{
			try 
			{
				//display target value
				ctrl2ValuesDisplay1.LblValue1.Text = wv.FormatKg();
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("eTargetWeightChange",ex);
				throw;
			}
		}
		
		void eRelativeBalanceWeightChange(WeightValue wv)
		{
			try 
			{
				//display ingredient relative value
				ctrl2ValuesDisplay1.LblValue2.Text = wv.FormatKg();
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("eRelativeBalanceWeightChange",ex);
				throw;
			}	
		}
		
		void eReferenceWeightChange(WeightValue wv)
		{
			try 
			{
				_relativeBalanceWeight.Value = GV.Instance.TotalBalanceWeight.Value - _referenceWeight.Value;
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("eReferenceWeightChange",ex);
				throw;
			}
		}
		
		
		void FrmAutomaticModeClientSizeChanged(object sender, EventArgs e)
		{
			try 
			{
				this.ResizeChildrenText();
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("FrmAutomaticModeClientSizeChanged",ex);
				throw;
			}	
		}
		void Ctrl2ValuesDisplay1Load(object sender, EventArgs e)
		{
	
		}
		void CtrlBtnQuitMouseDown(object sender, MouseEventArgs e)
		{
			this.Close();
		}
		

		void FrmAutomaticModeKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Back)
			{
				this.Close();
			}
		}
		
		void FrmAutomaticModeFormClosing(object sender, FormClosingEventArgs e)
		{
			try 
			{
				GV.Instance.TotalBalanceWeight.WeightChangedDel  -= eTotalBalanceWeightChange;
				GR.Instance.BalanceSerialPort._connectionStatusChange -= eConnectionStatusChange;
				GR.Instance.OutputCtrl.SetAllIngredientOff();
			} 
			catch (Exception ex) 
			{	
				SimpleLogger.Logger.Log("FrmAutomaticModeFormClosing",ex);
				throw;
			}
		}
	}
}
