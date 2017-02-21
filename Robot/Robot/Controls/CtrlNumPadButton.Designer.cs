/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 11:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class CtrlNumPadButton
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			// 
			// CtrlNumPadButton
			// 
			//this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
//			this.FlatAppearance.BorderColor = System.Drawing.Color.Black;
//			this.FlatAppearance.BorderSize = 0;
//			this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
//			this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Location = new System.Drawing.Point(119, 3);
			this.Name = "CtrlNumPadButton";
			this.Size = new System.Drawing.Size(110, 110);
			this.TabStop = false;
			this.Text = "";
			this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Margin = new System.Windows.Forms.Padding(3);
//			this.UseVisualStyleBackColor = false;
			
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxLength = 0;
			this.Name = "CtrlNumPadButton";
			this.Size = new System.Drawing.Size(110, 109);
			this.TabIndex = 0;
			this.Text = "";
			this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Margin = new System.Windows.Forms.Padding(3);
		}
	}
}
