/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 1/27/2017
 * Time: 7:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class frmWaitingTime
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Robot.CtrlLabel ctrlLabel1;
		private Robot.CtrlButton btnSortir;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ctrlLabel1 = new Robot.CtrlLabel();
			this.btnSortir = new Robot.CtrlButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.ctrlLabel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSortir, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 386);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ctrlLabel1
			// 
			this.ctrlLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlLabel1.Location = new System.Drawing.Point(3, 0);
			this.ctrlLabel1.MaxLength = 0;
			this.ctrlLabel1.Name = "ctrlLabel1";
			this.ctrlLabel1.Size = new System.Drawing.Size(707, 193);
			this.ctrlLabel1.TabIndex = 0;
			this.ctrlLabel1.Text = "ctrlLblCountdown";
			// 
			// btnSortir
			// 
			this.btnSortir.BackColor = System.Drawing.Color.Gainsboro;
			this.btnSortir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnSortir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSortir.Location = new System.Drawing.Point(3, 193);
			this.btnSortir.MaxLength = 0;
			this.btnSortir.Name = "btnSortir";
			this.btnSortir.Size = new System.Drawing.Size(707, 193);
			this.btnSortir.TabIndex = 1;
			this.btnSortir.Text = "Sortir";
			this.btnSortir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSortir.Click += new System.EventHandler(this.BtnSortirClick);
			// 
			// frmWaitingTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 386);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "frmWaitingTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmWaitingTime";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWaitingTimeFormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmWaitingTimeKeyDown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
