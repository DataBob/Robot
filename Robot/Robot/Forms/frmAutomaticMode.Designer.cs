/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/10/2016
 * Time: 12:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class frmAutomaticMode
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Robot.Controls.Ctrl2ValuesDisplay ctrl2ValuesDisplay1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private Robot.CtrlLabel ctrlLabelGroup;
		private Robot.CtrlLabel ctrlLabelIngredient;
		private Robot.CtrlLabel lblSerialPortStatus;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private Robot.CtrlButton ctrlBtnQuit;
		private Robot.CtrlFormConsole ctrlFormConsole2;
		
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
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.ctrl2ValuesDisplay1 = new Robot.Controls.Ctrl2ValuesDisplay();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.ctrlLabelGroup = new Robot.CtrlLabel();
			this.ctrlLabelIngredient = new Robot.CtrlLabel();
			this.lblSerialPortStatus = new Robot.CtrlLabel();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.ctrlBtnQuit = new Robot.CtrlButton();
			this.ctrlFormConsole2 = new Robot.CtrlFormConsole();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.21309F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.17796F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.82203F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 472);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.ctrl2ValuesDisplay1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.71698F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.28302F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(686, 363);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// ctrl2ValuesDisplay1
			// 
			this.ctrl2ValuesDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrl2ValuesDisplay1.Location = new System.Drawing.Point(3, 129);
			this.ctrl2ValuesDisplay1.Name = "ctrl2ValuesDisplay1";
			this.ctrl2ValuesDisplay1.Size = new System.Drawing.Size(680, 231);
			this.ctrl2ValuesDisplay1.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.ctrlLabelGroup, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.ctrlLabelIngredient, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.lblSerialPortStatus, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.78774F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.21226F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(680, 120);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// ctrlLabelGroup
			// 
			this.ctrlLabelGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctrlLabelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlLabelGroup.Location = new System.Drawing.Point(3, 21);
			this.ctrlLabelGroup.MaxLength = 0;
			this.ctrlLabelGroup.Name = "ctrlLabelGroup";
			this.ctrlLabelGroup.Size = new System.Drawing.Size(334, 99);
			this.ctrlLabelGroup.TabIndex = 0;
			this.ctrlLabelGroup.Text = "Groupe: x";
			this.ctrlLabelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ctrlLabelIngredient
			// 
			this.ctrlLabelIngredient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctrlLabelIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlLabelIngredient.Location = new System.Drawing.Point(343, 21);
			this.ctrlLabelIngredient.MaxLength = 0;
			this.ctrlLabelIngredient.Name = "ctrlLabelIngredient";
			this.ctrlLabelIngredient.Size = new System.Drawing.Size(334, 99);
			this.ctrlLabelIngredient.TabIndex = 1;
			this.ctrlLabelIngredient.Text = "Ingrédient:  x";
			this.ctrlLabelIngredient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSerialPortStatus
			// 
			this.lblSerialPortStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSerialPortStatus.Location = new System.Drawing.Point(3, 0);
			this.lblSerialPortStatus.MaxLength = 0;
			this.lblSerialPortStatus.Name = "lblSerialPortStatus";
			this.lblSerialPortStatus.Size = new System.Drawing.Size(334, 21);
			this.lblSerialPortStatus.TabIndex = 2;
			this.lblSerialPortStatus.Text = "ctrlLabel3";
			this.lblSerialPortStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.85423F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.14577F));
			this.tableLayoutPanel4.Controls.Add(this.ctrlBtnQuit, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.ctrlFormConsole2, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 372);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(686, 97);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// ctrlBtnQuit
			// 
			this.ctrlBtnQuit.BackColor = System.Drawing.Color.Gainsboro;
			this.ctrlBtnQuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ctrlBtnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlBtnQuit.Location = new System.Drawing.Point(345, 0);
			this.ctrlBtnQuit.MaxLength = 0;
			this.ctrlBtnQuit.Name = "ctrlBtnQuit";
			this.ctrlBtnQuit.Size = new System.Drawing.Size(338, 97);
			this.ctrlBtnQuit.TabIndex = 1;
			this.ctrlBtnQuit.Text = "Sortir";
			this.ctrlBtnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ctrlBtnQuit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CtrlBtnQuitMouseDown);
			// 
			// ctrlFormConsole2
			// 
			this.ctrlFormConsole2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlFormConsole2.Location = new System.Drawing.Point(3, 3);
			this.ctrlFormConsole2.Name = "ctrlFormConsole2";
			this.ctrlFormConsole2.Size = new System.Drawing.Size(336, 91);
			this.ctrlFormConsole2.TabIndex = 2;
			// 
			// frmAutomaticMode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 472);
			this.Controls.Add(this.tableLayoutPanel1);
			this.KeyPreview = true;
			this.Name = "frmAutomaticMode";
			this.Text = "frmAutomaticMode";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAutomaticModeFormClosing);
			this.ClientSizeChanged += new System.EventHandler(this.FrmAutomaticModeClientSizeChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAutomaticModeKeyDown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
