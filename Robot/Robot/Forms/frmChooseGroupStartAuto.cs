/*
 * Created by SharpDevelop.
 * User: User
 * Date: 8/18/2016
 * Time: 6:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of frmChooseGroupStartAuto.
	/// </summary>
	public partial class frmChooseGroupStartAuto : Form
	{
		public frmChooseGroupStartAuto()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.ResizeChildrenText();
			
		}
		void FrmChooseGroupStartAutoClientSizeChanged(object sender, EventArgs e)
		{
			this.ResizeChildrenText();
		}
		void BtnSortirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnStartClick(object sender, EventArgs e)
		{
			StartAutomaticMode();
		}

		
		void StartAutomaticMode()
		{
			if(GR.Instance.BalanceSerialPort.SerialPortActive)
			{
				bool fillingCompleted;
				using(var frm = new frmAutomaticMode(this.ctrlGroupSelect1.SelectedGroup))
				{
					frm.ShowDialog();
					fillingCompleted = frm.FillingCompleted;
				}
				
				if(fillingCompleted)
				{
					using(var frm2 = new frmWaitingTime())
					{
						frm2.ShowDialog();
					}
				}
			}
			else
			{
				MessageBox.Show("Serial port not connected");
			}
		}

		void FrmChooseGroupStartAutoKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				StartAutomaticMode();
			}
//			if(e.KeyCode == Keys.Back)
//			{
//				this.Close();
//			}
		}
	}
}
