/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/10/2016
 * Time: 12:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot.Controls
{
	partial class Ctrl2ValuesDisplay
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private CtrlLabel lblValue2;
		private CtrlLabel lblValue1;
		private CtrlLabel lblTitle2;
		private CtrlLabel lblTitle1;
		
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
			this.lblValue2 = new CtrlLabel();
			this.lblValue1 = new CtrlLabel();
			this.lblTitle2 = new CtrlLabel();
			this.lblTitle1 = new CtrlLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lblValue2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblValue1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblTitle2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblTitle1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 99);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// lblValue2
			// 
			this.lblValue2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblValue2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValue2.Location = new System.Drawing.Point(148, 52);
			this.lblValue2.Margin = new System.Windows.Forms.Padding(3);
			this.lblValue2.Name = "lblValue2";
			this.lblValue2.Size = new System.Drawing.Size(140, 44);
			this.lblValue2.TabIndex = 13;
			this.lblValue2.Text = "9999 KG";
			this.lblValue2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblValue1
			// 
			this.lblValue1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblValue1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValue1.Location = new System.Drawing.Point(148, 3);
			this.lblValue1.Margin = new System.Windows.Forms.Padding(3);
			this.lblValue1.Name = "lblValue1";
			this.lblValue1.Size = new System.Drawing.Size(140, 43);
			this.lblValue1.TabIndex = 13;
			this.lblValue1.Text = "9999 KG";
			this.lblValue1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTitle2
			// 
			this.lblTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle2.Location = new System.Drawing.Point(3, 52);
			this.lblTitle2.Margin = new System.Windows.Forms.Padding(3);
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Size = new System.Drawing.Size(139, 44);
			this.lblTitle2.TabIndex = 3;
			this.lblTitle2.Text = "Balance:";
			this.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTitle1
			// 
			this.lblTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle1.Location = new System.Drawing.Point(3, 3);
			this.lblTitle1.Margin = new System.Windows.Forms.Padding(3);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new System.Drawing.Size(139, 43);
			this.lblTitle1.TabIndex = 1;
			this.lblTitle1.Text = "Cible:";
			this.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Ctrl2ValuesDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Ctrl2ValuesDisplay";
			this.Size = new System.Drawing.Size(297, 105);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
