/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 4:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class CtrlGroupSelect
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton3;
		CtrlLabel label1;
		
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.radioButton8 = new CtrlRadioButton();
			this.radioButton7 = new CtrlRadioButton();
			this.radioButton6 = new CtrlRadioButton();
			this.radioButton5 = new CtrlRadioButton();
			this.radioButton1 = new CtrlRadioButton();
			this.radioButton2 = new CtrlRadioButton();
			this.radioButton4 = new CtrlRadioButton();
			this.radioButton3 = new CtrlRadioButton();
			this.label1 = new CtrlLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.radioButton8, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.radioButton7, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.radioButton6, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.radioButton5, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButton2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.radioButton4, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.radioButton3, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 9;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(143, 528);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// radioButton8
			// 
			this.radioButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton8.AutoSize = true;
			this.radioButton8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton8.FlatAppearance.BorderSize = 3;
			this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton8.Location = new System.Drawing.Point(4, 463);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(135, 61);
			this.radioButton8.TabIndex = 7;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "8";
			this.radioButton8.UseVisualStyleBackColor = false;
			this.radioButton8.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// radioButton7
			// 
			this.radioButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton7.AutoSize = true;
			this.radioButton7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton7.FlatAppearance.BorderSize = 3;
			this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton7.Location = new System.Drawing.Point(4, 402);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(135, 54);
			this.radioButton7.TabIndex = 6;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "7";
			this.radioButton7.UseVisualStyleBackColor = false;
			this.radioButton7.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// radioButton6
			// 
			this.radioButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton6.AutoSize = true;
			this.radioButton6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton6.FlatAppearance.BorderSize = 3;
			this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton6.Location = new System.Drawing.Point(4, 341);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(135, 54);
			this.radioButton6.TabIndex = 5;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "6";
			this.radioButton6.UseVisualStyleBackColor = false;
			this.radioButton6.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// radioButton5
			// 
			this.radioButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton5.AutoSize = true;
			this.radioButton5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton5.FlatAppearance.BorderSize = 3;
			this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton5.Location = new System.Drawing.Point(4, 280);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(135, 54);
			this.radioButton5.TabIndex = 4;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "5";
			this.radioButton5.UseVisualStyleBackColor = false;
			this.radioButton5.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// radioButton1
			// 
			this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton1.AutoSize = true;
			this.radioButton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton1.FlatAppearance.BorderSize = 3;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(4, 36);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(135, 54);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "1";
			this.radioButton1.UseVisualStyleBackColor = false;
			this.radioButton1.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// radioButton2
			// 
			this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton2.AutoSize = true;
			this.radioButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton2.FlatAppearance.BorderSize = 3;
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(4, 97);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(135, 54);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "2";
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// radioButton4
			// 
			this.radioButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton4.AutoSize = true;
			this.radioButton4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton4.FlatAppearance.BorderSize = 3;
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(4, 219);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(135, 54);
			this.radioButton4.TabIndex = 3;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "4";
			this.radioButton4.UseVisualStyleBackColor = false;
			this.radioButton4.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// radioButton3
			// 
			this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.radioButton3.AutoSize = true;
			this.radioButton3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.radioButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.radioButton3.FlatAppearance.BorderSize = 3;
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(4, 158);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(135, 54);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "3";
			this.radioButton3.UseVisualStyleBackColor = false;
			this.radioButton3.Enter += new System.EventHandler(this.RadioButtonEnter);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 31);
			this.label1.TabIndex = 8;
			this.label1.Text = "Groupes:";
			// 
			// CtrlGroupSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "CtrlGroupSelect";
			this.Size = new System.Drawing.Size(149, 534);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
