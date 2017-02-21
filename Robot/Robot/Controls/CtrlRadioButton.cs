/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/10/2016
 * Time: 8:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of CtrlRadioButton.
	/// </summary>
	public partial class CtrlRadioButton : RadioButton, ICtrlAutoResizable 
	{
		public int MaxLength { get; set; }
		
		
		public CtrlRadioButton()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		public void ResizeControlText()
		{
			string strMaxLength;
			var ctrl = this;
			if(ctrl.MaxLength > 0)
			{
				strMaxLength = "".PadLeft(ctrl.MaxLength);
			}
			else
			{
				strMaxLength = ctrl.Text;
			}
			
				 // If there's no text, return
		    if (strMaxLength.Length == 0) return;
		
		    // Get height and width, we'll be using these repeatedly
		    int height = (int)(ctrl.Height * 0.8);
		    int width = ctrl.Width;
		
		    // Suspend layout while we mess with stuff
		    ctrl.SuspendLayout();
		
		    Font tryFont = ctrl.Font;
		    Size tempSize = TextRenderer.MeasureText( strMaxLength, ctrl.Font);
		
		    // Make sure it isn't too small first
		    while (tempSize.Height < height || tempSize.Width < width)
		    {
		        tryFont = new Font(tryFont.FontFamily, tryFont.Size + 3, tryFont.Style);
		        tempSize = TextRenderer.MeasureText(strMaxLength, tryFont);
		    }
		
		    // Now make sure it isn't too big
		    while (tempSize.Height > height || tempSize.Width > width)
		    {
		        if(tryFont.Size > 6)
		    	{
			        tryFont = new Font(tryFont.FontFamily, tryFont.Size - 3, tryFont.Style);
			        tempSize = TextRenderer.MeasureText(strMaxLength, tryFont);
		    	}
		    }
		
		    // Swap the font
		    ctrl.Font = tryFont;
		
		    // Resume layout
		    ctrl.ResumeLayout();
		}		
	}
}
