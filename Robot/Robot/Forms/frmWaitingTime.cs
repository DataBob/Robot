/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 1/27/2017
 * Time: 7:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
	
	
	
	/// <summary>
	/// Description of frmWaitingTime.
	/// </summary>
	public partial class frmWaitingTime : Form
	{
		private class StateObjClass
		{
		    public int _countdown = 180;
		    public Timer  _timerReference;
		    readonly frmWaitingTime _frmWaiting;
		    
		    public StateObjClass(frmWaitingTime frmWaiting)
		    {
		    	_frmWaiting = frmWaiting;
		    	_timerReference = new Timer();
		    	_timerReference.Tick += (sender, e) => { OnTimedEvent(this); };
			    _timerReference.Interval=1000;
			    _timerReference.Enabled = true;
			    _timerReference.Start();
		    }
		    
		    private static void OnTimedEvent(StateObjClass state)
		    {
		    	state.CountDown();
			}
		    
		    private void CountDown()
		    {
		    	lock(this)
		    	{
		    		if(_countdown > 0)
					{
						_countdown--;
						_frmWaiting.UpdateCountDown(_countdown);
					}
					else
					{
						_timerReference.Stop();
						_frmWaiting.CloseWindow();
					}
		    	}
		    }
		    
		    public void StopTimer()
		    {
		    	lock(this)
		    	{
		    		_timerReference.Stop();
		    	}
		    }
		}
		
		StateObjClass _timer;
		
		public frmWaitingTime()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			_timer = new StateObjClass(this);
			UpdateCountDown(180);
			this.ResizeChildrenText();
			//turn light and water
			GR.Instance.OutputCtrl.SetIngredientOn(8);
		}
		
		public void UpdateCountDown(int countdown)
		{
			this.InvokeIfRequired( c => { ctrlLabel1.Text = countdown.ToString(); } );	
		}
		
		public void CloseWindow()
		{
			this.InvokeIfRequired( c => { this.Close(); } );
		}
		
		void BtnSortirClick(object sender, EventArgs e)
		{
				this.Close();
		}
		
		void FrmWaitingTimeKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Back)
			{
				this.Close();
			}
		}
		void FrmWaitingTimeFormClosing(object sender, FormClosingEventArgs e)
		{
			//turn off light and water
			GR.Instance.OutputCtrl.SetIngredientOff(8);
			_timer.StopTimer();
		}
		
	}
}
