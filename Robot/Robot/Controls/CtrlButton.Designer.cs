/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/10/2016
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System.Windows.Forms;
using System.Drawing;

namespace Robot
{
	partial class CtrlButton
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
			// CtrlButton
			// 
			this.Name = "CtrlButton";
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextAlign = ContentAlignment.MiddleCenter;
			this.BackColor = Color.Gainsboro;
		}
	}
}
