/*
 * Created by SharpDevelop.
 * User: User
 * Date: 4/2/2016
 * Time: 5:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Robot
{
	partial class frmRecipe
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblRecipeName;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnLancer;
		private System.Windows.Forms.Button btnModify;
		
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
			this.lblRecipeName = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnLancer = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblRecipeName
			// 
			this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
			this.lblRecipeName.Name = "lblRecipeName";
			this.lblRecipeName.Size = new System.Drawing.Size(265, 66);
			this.lblRecipeName.TabIndex = 0;
			this.lblRecipeName.Text = "lblRecipeName";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.lblRecipeName);
			this.flowLayoutPanel1.Controls.Add(this.btnLancer);
			this.flowLayoutPanel1.Controls.Add(this.btnModify);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 406);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// btnModify
			// 
			this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModify.Location = new System.Drawing.Point(3, 151);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(213, 76);
			this.btnModify.TabIndex = 1;
			this.btnModify.Text = "Modifier";
			this.btnModify.UseVisualStyleBackColor = true;
			// 
			// btnLancer
			// 
			this.btnLancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLancer.Location = new System.Drawing.Point(3, 69);
			this.btnLancer.Name = "btnLancer";
			this.btnLancer.Size = new System.Drawing.Size(213, 76);
			this.btnLancer.TabIndex = 2;
			this.btnLancer.Text = "Lancer";
			this.btnLancer.UseVisualStyleBackColor = true;
			// 
			// Recipe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 406);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Recipe";
			this.Text = "Recipe";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
