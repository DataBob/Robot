/*
 * Created by SharpDevelop.
 * User: User
 * Date: 4/2/2016
 * Time: 6:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class frmEditRecipe
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Robot.CtrlNumPad ctrlNumPad;
		private CtrlButton btnQuit;
		private Robot.CtrlIngredientSelect ctrlIngredientSelect;
		private Robot.CtrlGroupSelect ctrlGroupSelect;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private Robot.Controls.Ctrl2ValuesDisplay ctrl2ValuesDisplay1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		
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
			this.btnQuit = new Robot.CtrlButton();
			this.ctrlIngredientSelect = new Robot.CtrlIngredientSelect();
			this.ctrlGroupSelect = new Robot.CtrlGroupSelect();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.ctrl2ValuesDisplay1 = new Robot.Controls.Ctrl2ValuesDisplay();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ctrlNumPad
			// 
			this.ctrlNumPad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ctrlNumPad.Location = new System.Drawing.Point(3, 126);
			this.ctrlNumPad.Name = "ctrlNumPad";
			this.ctrlNumPad.Size = new System.Drawing.Size(366, 427);
			this.ctrlNumPad.TabIndex = 0;
			// 
			// btnQuit
			// 
			this.btnQuit.BackColor = System.Drawing.Color.Gainsboro;
			this.btnQuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnQuit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuit.Location = new System.Drawing.Point(3, 464);
			this.btnQuit.MaxLength = 0;
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(108, 85);
			this.btnQuit.TabIndex = 11;
			this.btnQuit.Text = "Sortir";
			this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
			// 
			// ctrlIngredientSelect
			// 
			this.ctrlIngredientSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ctrlIngredientSelect.Location = new System.Drawing.Point(549, 3);
			this.ctrlIngredientSelect.Name = "ctrlIngredientSelect";
			this.ctrlIngredientSelect.Size = new System.Drawing.Size(162, 556);
			this.ctrlIngredientSelect.TabIndex = 12;
			// 
			// ctrlGroupSelect
			// 
			this.ctrlGroupSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ctrlGroupSelect.Location = new System.Drawing.Point(3, 3);
			this.ctrlGroupSelect.Name = "ctrlGroupSelect";
			this.ctrlGroupSelect.Size = new System.Drawing.Size(162, 556);
			this.ctrlGroupSelect.TabIndex = 13;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel2.Controls.Add(this.ctrlGroupSelect, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ctrlIngredientSelect, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 562);
			this.tableLayoutPanel2.TabIndex = 15;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.ctrlNumPad, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.ctrl2ValuesDisplay1, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(171, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.14076F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.85924F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 556);
			this.tableLayoutPanel3.TabIndex = 14;
			// 
			// ctrl2ValuesDisplay1
			// 
			this.ctrl2ValuesDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ctrl2ValuesDisplay1.Location = new System.Drawing.Point(3, 3);
			this.ctrl2ValuesDisplay1.Name = "ctrl2ValuesDisplay1";
			this.ctrl2ValuesDisplay1.Size = new System.Drawing.Size(366, 117);
			this.ctrl2ValuesDisplay1.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnQuit, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(717, 3);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.53237F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.46763F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(114, 549);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// frmEditRecipe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 562);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "frmEditRecipe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "EditRecipe";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditRecipeFormClosing);
			this.ClientSizeChanged += new System.EventHandler(this.FrmEditRecipeClientSizeChanged);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
