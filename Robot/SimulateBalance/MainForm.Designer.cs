/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 2/6/2017
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimulateBalance
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtCurrent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAdd;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnReset;
		
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
			this.txtCurrent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAdd = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCurrent
			// 
			this.txtCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCurrent.Location = new System.Drawing.Point(118, 6);
			this.txtCurrent.Name = "txtCurrent";
			this.txtCurrent.Size = new System.Drawing.Size(100, 31);
			this.txtCurrent.TabIndex = 0;
			this.txtCurrent.Text = "0";
			this.txtCurrent.TextChanged += new System.EventHandler(this.TxtCurrentTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Current:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Add:";
			// 
			// txtAdd
			// 
			this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdd.Location = new System.Drawing.Point(118, 38);
			this.txtAdd.Name = "txtAdd";
			this.txtAdd.Size = new System.Drawing.Size(100, 31);
			this.txtAdd.TabIndex = 4;
			this.txtAdd.Text = "10";
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(224, 38);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(95, 31);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(224, 6);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(95, 31);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 81);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtAdd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCurrent);
			this.Name = "MainForm";
			this.Text = "SimulateBalance";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
