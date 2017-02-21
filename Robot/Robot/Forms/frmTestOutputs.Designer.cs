/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 8:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class frmTestOutputs
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Robot.CtrlTestOutput ctrlTestOutput1;
		
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
			this.ctrlTestOutput1 = new Robot.CtrlTestOutput();
			this.SuspendLayout();
			// 
			// ctrlTestOutput1
			// 
			this.ctrlTestOutput1.Location = new System.Drawing.Point(12, 11);
			this.ctrlTestOutput1.Name = "ctrlTestOutput1";
			this.ctrlTestOutput1.Size = new System.Drawing.Size(182, 515);
			this.ctrlTestOutput1.TabIndex = 0;
			// 
			// frmTestOutputs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(207, 538);
			this.Controls.Add(this.ctrlTestOutput1);
			this.Name = "frmTestOutputs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTestOutputs";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTestOutputsFormClosing);
			this.ResumeLayout(false);

		}
	}
}
