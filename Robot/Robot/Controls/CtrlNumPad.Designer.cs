/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 8:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class CtrlNumPad
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		CtrlNumPadButton btnNum7;
		CtrlNumPadButton btnNum8;
		CtrlNumPadButton btnNum9;
		CtrlNumPadButton btnNum4;
		CtrlNumPadButton btnNum5;
		CtrlNumPadButton btnNum6;
		CtrlNumPadButton btnNum1;
		CtrlNumPadButton btnNum2;
		CtrlNumPadButton btnNum3;
		CtrlNumPadButton buttonDot;
		CtrlNumPadButton btnNum0;
		CtrlNumPadButton btnDel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.btnNum7 = new Robot.CtrlNumPadButton();
			this.btnNum8 = new Robot.CtrlNumPadButton();
			this.btnNum9 = new Robot.CtrlNumPadButton();
			this.btnNum4 = new Robot.CtrlNumPadButton();
			this.btnNum5 = new Robot.CtrlNumPadButton();
			this.btnNum6 = new Robot.CtrlNumPadButton();
			this.btnNum1 = new Robot.CtrlNumPadButton();
			this.btnNum2 = new Robot.CtrlNumPadButton();
			this.btnNum3 = new Robot.CtrlNumPadButton();
			this.buttonDot = new Robot.CtrlNumPadButton();
			this.btnNum0 = new Robot.CtrlNumPadButton();
			this.btnDel = new Robot.CtrlNumPadButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnNum7
			// 
			this.btnNum7.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum7.Location = new System.Drawing.Point(3, 3);
			this.btnNum7.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum7.MaxLength = 0;
			this.btnNum7.Name = "btnNum7";
			this.btnNum7.Size = new System.Drawing.Size(110, 109);
			this.btnNum7.TabIndex = 0;
			this.btnNum7.Text = "7";
			this.btnNum7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum8
			// 
			this.btnNum8.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum8.Location = new System.Drawing.Point(119, 3);
			this.btnNum8.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum8.MaxLength = 0;
			this.btnNum8.Name = "btnNum8";
			this.btnNum8.Size = new System.Drawing.Size(111, 109);
			this.btnNum8.TabIndex = 1;
			this.btnNum8.Text = "8";
			this.btnNum8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum9
			// 
			this.btnNum9.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum9.Location = new System.Drawing.Point(236, 3);
			this.btnNum9.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum9.MaxLength = 0;
			this.btnNum9.Name = "btnNum9";
			this.btnNum9.Size = new System.Drawing.Size(112, 109);
			this.btnNum9.TabIndex = 2;
			this.btnNum9.Text = "9";
			this.btnNum9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum4
			// 
			this.btnNum4.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum4.Location = new System.Drawing.Point(3, 118);
			this.btnNum4.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum4.MaxLength = 0;
			this.btnNum4.Name = "btnNum4";
			this.btnNum4.Size = new System.Drawing.Size(110, 109);
			this.btnNum4.TabIndex = 3;
			this.btnNum4.Text = "4";
			this.btnNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum5
			// 
			this.btnNum5.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum5.Location = new System.Drawing.Point(119, 118);
			this.btnNum5.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum5.MaxLength = 0;
			this.btnNum5.Name = "btnNum5";
			this.btnNum5.Size = new System.Drawing.Size(111, 109);
			this.btnNum5.TabIndex = 4;
			this.btnNum5.Text = "5";
			this.btnNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum6
			// 
			this.btnNum6.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum6.Location = new System.Drawing.Point(236, 118);
			this.btnNum6.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum6.MaxLength = 0;
			this.btnNum6.Name = "btnNum6";
			this.btnNum6.Size = new System.Drawing.Size(112, 109);
			this.btnNum6.TabIndex = 5;
			this.btnNum6.Text = "6";
			this.btnNum6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum1
			// 
			this.btnNum1.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum1.Location = new System.Drawing.Point(3, 233);
			this.btnNum1.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum1.MaxLength = 0;
			this.btnNum1.Name = "btnNum1";
			this.btnNum1.Size = new System.Drawing.Size(110, 109);
			this.btnNum1.TabIndex = 6;
			this.btnNum1.Text = "1";
			this.btnNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum2
			// 
			this.btnNum2.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum2.Location = new System.Drawing.Point(119, 233);
			this.btnNum2.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum2.MaxLength = 0;
			this.btnNum2.Name = "btnNum2";
			this.btnNum2.Size = new System.Drawing.Size(111, 109);
			this.btnNum2.TabIndex = 7;
			this.btnNum2.Text = "2";
			this.btnNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnNum3
			// 
			this.btnNum3.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum3.Location = new System.Drawing.Point(236, 233);
			this.btnNum3.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum3.MaxLength = 0;
			this.btnNum3.Name = "btnNum3";
			this.btnNum3.Size = new System.Drawing.Size(112, 109);
			this.btnNum3.TabIndex = 8;
			this.btnNum3.Text = "3";
			this.btnNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// buttonDot
			// 
			this.buttonDot.BackColor = System.Drawing.Color.Gainsboro;
			this.buttonDot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.buttonDot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonDot.Enabled = false;
			this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDot.Location = new System.Drawing.Point(3, 348);
			this.buttonDot.Margin = new System.Windows.Forms.Padding(3);
			this.buttonDot.MaxLength = 0;
			this.buttonDot.Name = "buttonDot";
			this.buttonDot.Size = new System.Drawing.Size(110, 112);
			this.buttonDot.TabIndex = 9;
			this.buttonDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNum0
			// 
			this.btnNum0.BackColor = System.Drawing.Color.Gainsboro;
			this.btnNum0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNum0.Location = new System.Drawing.Point(119, 348);
			this.btnNum0.Margin = new System.Windows.Forms.Padding(3);
			this.btnNum0.MaxLength = 0;
			this.btnNum0.Name = "btnNum0";
			this.btnNum0.Size = new System.Drawing.Size(111, 112);
			this.btnNum0.TabIndex = 10;
			this.btnNum0.Text = "0";
			this.btnNum0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnNum0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.Gainsboro;
			this.btnDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.Location = new System.Drawing.Point(236, 348);
			this.btnDel.Margin = new System.Windows.Forms.Padding(3);
			this.btnDel.MaxLength = 0;
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(112, 112);
			this.btnDel.TabIndex = 11;
			this.btnDel.Text = "Del";
			this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnDel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNumMouseDown);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.btnDel, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnNum0, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.buttonDot, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btnNum3, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnNum2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnNum1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnNum6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnNum5, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnNum4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnNum9, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnNum8, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnNum7, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(351, 463);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// CtrlNumPad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Location = new System.Drawing.Point(3, 3);
			this.Name = "CtrlNumPad";
			this.Size = new System.Drawing.Size(351, 463);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
