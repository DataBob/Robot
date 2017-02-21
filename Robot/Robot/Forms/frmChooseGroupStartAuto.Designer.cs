/*
 * Created by SharpDevelop.
 * User: User
 * Date: 8/18/2016
 * Time: 6:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class frmChooseGroupStartAuto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Robot.CtrlGroupSelect ctrlGroupSelect1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private Robot.CtrlButton btnSortir;
		private Robot.CtrlButton btnStart;
		
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
			this.ctrlGroupSelect1 = new Robot.CtrlGroupSelect();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSortir = new Robot.CtrlButton();
			this.btnStart = new Robot.CtrlButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.ctrlGroupSelect1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 567);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ctrlGroupSelect1
			// 
			this.ctrlGroupSelect1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlGroupSelect1.Location = new System.Drawing.Point(3, 3);
			this.ctrlGroupSelect1.Name = "ctrlGroupSelect1";
			this.ctrlGroupSelect1.Size = new System.Drawing.Size(501, 561);
			this.ctrlGroupSelect1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btnSortir, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.btnStart, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(510, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(501, 561);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// btnSortir
			// 
			this.btnSortir.BackColor = System.Drawing.Color.Gainsboro;
			this.btnSortir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnSortir.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSortir.Location = new System.Drawing.Point(7, 483);
			this.btnSortir.Margin = new System.Windows.Forms.Padding(7);
			this.btnSortir.MaxLength = 0;
			this.btnSortir.Name = "btnSortir";
			this.btnSortir.Size = new System.Drawing.Size(487, 71);
			this.btnSortir.TabIndex = 0;
			this.btnSortir.Text = "Sortir";
			this.btnSortir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSortir.Click += new System.EventHandler(this.BtnSortirClick);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStart.Location = new System.Drawing.Point(7, 7);
			this.btnStart.Margin = new System.Windows.Forms.Padding(7);
			this.btnStart.MaxLength = 0;
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(487, 70);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Démarrer";
			this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// frmChooseGroupStartAuto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 567);
			this.Controls.Add(this.tableLayoutPanel1);
			this.KeyPreview = true;
			this.Name = "frmChooseGroupStartAuto";
			this.Text = "frmChooseGroupStartAuto";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ClientSizeChanged += new System.EventHandler(this.FrmChooseGroupStartAutoClientSizeChanged);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmChooseGroupStartAutoKeyDown);
	
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
