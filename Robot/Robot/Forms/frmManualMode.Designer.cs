/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 7/18/2016
 * Time: 8:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class frmManualMode
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnStartStop;
		private Robot.CtrlNumPad ctrlNumPad;
		private Robot.CtrlIngredientSelect ctrlIngredientSelect1;
		private System.Windows.Forms.Button btnQuit;
		private Robot.Controls.Ctrl2ValuesDisplay ctrl2ValuesDisplay1;
		
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
			this.ctrlNumPad = new Robot.CtrlNumPad();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.btnQuit = new System.Windows.Forms.Button();
			this.ctrlIngredientSelect1 = new Robot.CtrlIngredientSelect();
			this.ctrl2ValuesDisplay1 = new Robot.Controls.Ctrl2ValuesDisplay();
			this.SuspendLayout();
			// 
			// ctrlNumPad
			// 
			this.ctrlNumPad.Location = new System.Drawing.Point(463, 12);
			this.ctrlNumPad.Name = "ctrlNumPad";
			this.ctrlNumPad.Size = new System.Drawing.Size(357, 479);
			this.ctrlNumPad.TabIndex = 1;
			// 
			// btnStartStop
			// 
			this.btnStartStop.BackColor = System.Drawing.Color.Lime;
			this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartStop.Location = new System.Drawing.Point(13, 167);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(436, 99);
			this.btnStartStop.TabIndex = 8;
			this.btnStartStop.Text = "Start";
			this.btnStartStop.UseVisualStyleBackColor = false;
			this.btnStartStop.Click += new System.EventHandler(this.BtnStartStopClick);
			// 
			// btnQuit
			// 
			this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuit.Location = new System.Drawing.Point(731, 497);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(230, 63);
			this.btnQuit.TabIndex = 10;
			this.btnQuit.Text = "Sortir";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// ctrlIngredientSelect1
			// 
			this.ctrlIngredientSelect1.Location = new System.Drawing.Point(827, 15);
			this.ctrlIngredientSelect1.Name = "ctrlIngredientSelect1";
			this.ctrlIngredientSelect1.Size = new System.Drawing.Size(134, 476);
			this.ctrlIngredientSelect1.TabIndex = 12;
			this.ctrlIngredientSelect1.IngredientChangeOccurred += new System.EventHandler<Robot.CtrlIngredientSelectEventArgs>(this.CtrlIngredientSelect1IngredientChangeOccurred);
			// 
			// ctrl2ValuesDisplay1
			// 
			this.ctrl2ValuesDisplay1.Location = new System.Drawing.Point(13, 15);
			this.ctrl2ValuesDisplay1.Name = "ctrl2ValuesDisplay1";
			this.ctrl2ValuesDisplay1.Size = new System.Drawing.Size(436, 146);
			this.ctrl2ValuesDisplay1.TabIndex = 13;
			// 
			// frmManualMode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 567);
			this.Controls.Add(this.ctrl2ValuesDisplay1);
			this.Controls.Add(this.ctrlIngredientSelect1);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.ctrlNumPad);
			this.Controls.Add(this.btnStartStop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmManualMode";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmManualMode";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManualModeFormClosing);
			this.ResumeLayout(false);

		}
	}
}
