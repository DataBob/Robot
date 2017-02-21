/*
 * Created by SharpDevelop.
 * User: User
 * Date: 4/2/2016
 * Time: 5:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private CtrlButton btnManualMode;
		private CtrlButton btnEditReciple;
		private CtrlButton btnTestOutput;
		private CtrlButton btnAutoMode;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private Robot.CtrlButton btnSerialPort;
		
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
			this.btnEditReciple = new Robot.CtrlButton();
			this.btnTestOutput = new Robot.CtrlButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSerialPort = new Robot.CtrlButton();
			this.btnManualMode = new Robot.CtrlButton();
			this.btnAutoMode = new Robot.CtrlButton();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEditReciple
			// 
			this.btnEditReciple.BackColor = System.Drawing.Color.Gainsboro;
			this.btnEditReciple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnEditReciple.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEditReciple.Location = new System.Drawing.Point(7, 81);
			this.btnEditReciple.Margin = new System.Windows.Forms.Padding(7);
			this.btnEditReciple.MaxLength = 0;
			this.btnEditReciple.Name = "btnEditReciple";
			this.btnEditReciple.Size = new System.Drawing.Size(529, 60);
			this.btnEditReciple.TabIndex = 2;
			this.btnEditReciple.Text = "Edition Recette";
			this.btnEditReciple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnEditReciple.Click += new System.EventHandler(this.eShowfrmEditRecipe);
			// 
			// btnTestOutput
			// 
			this.btnTestOutput.BackColor = System.Drawing.Color.Gainsboro;
			this.btnTestOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnTestOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTestOutput.Location = new System.Drawing.Point(7, 229);
			this.btnTestOutput.Margin = new System.Windows.Forms.Padding(7);
			this.btnTestOutput.MaxLength = 0;
			this.btnTestOutput.Name = "btnTestOutput";
			this.btnTestOutput.Size = new System.Drawing.Size(529, 60);
			this.btnTestOutput.TabIndex = 3;
			this.btnTestOutput.Text = "Test Output";
			this.btnTestOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnTestOutput.Click += new System.EventHandler(this.eShowfrmTestOutputs);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.85366F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.14634F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 577);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btnSerialPort, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.btnManualMode, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.btnTestOutput, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.btnEditReciple, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.btnAutoMode, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(543, 373);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// btnSerialPort
			// 
			this.btnSerialPort.BackColor = System.Drawing.Color.Gainsboro;
			this.btnSerialPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnSerialPort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSerialPort.Location = new System.Drawing.Point(7, 303);
			this.btnSerialPort.Margin = new System.Windows.Forms.Padding(7);
			this.btnSerialPort.MaxLength = 0;
			this.btnSerialPort.Name = "btnSerialPort";
			this.btnSerialPort.Size = new System.Drawing.Size(529, 63);
			this.btnSerialPort.TabIndex = 5;
			this.btnSerialPort.Text = "Serial Port";
			this.btnSerialPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnSerialPort.Click += new System.EventHandler(this.BtnSerialPortClick);
			// 
			// btnManualMode
			// 
			this.btnManualMode.BackColor = System.Drawing.Color.Gainsboro;
			this.btnManualMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnManualMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnManualMode.Location = new System.Drawing.Point(7, 155);
			this.btnManualMode.Margin = new System.Windows.Forms.Padding(7);
			this.btnManualMode.MaxLength = 0;
			this.btnManualMode.Name = "btnManualMode";
			this.btnManualMode.Size = new System.Drawing.Size(529, 60);
			this.btnManualMode.TabIndex = 3;
			this.btnManualMode.Text = "Mode Manuel";
			this.btnManualMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnManualMode.Click += new System.EventHandler(this.eShowfrmManualMode);
			// 
			// btnAutoMode
			// 
			this.btnAutoMode.BackColor = System.Drawing.Color.Gainsboro;
			this.btnAutoMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btnAutoMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAutoMode.Location = new System.Drawing.Point(7, 7);
			this.btnAutoMode.Margin = new System.Windows.Forms.Padding(7);
			this.btnAutoMode.MaxLength = 0;
			this.btnAutoMode.Name = "btnAutoMode";
			this.btnAutoMode.Size = new System.Drawing.Size(529, 60);
			this.btnAutoMode.TabIndex = 4;
			this.btnAutoMode.Text = "Mode Automatique";
			this.btnAutoMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAutoMode.Click += new System.EventHandler(this.eShowfrmAutomaticMode);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(549, 577);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainForm";
			this.Text = "Robot";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.ClientSizeChanged += new System.EventHandler(this.MainFormClientSizeChanged);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
