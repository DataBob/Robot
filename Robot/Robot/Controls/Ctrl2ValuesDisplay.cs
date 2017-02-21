/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/10/2016
 * Time: 12:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Robot.Controls
{
	/// <summary>
	/// Description of Ctrl2ValuesDisplay.
	/// </summary>
	public partial class Ctrl2ValuesDisplay : UserControl
	{
		public Ctrl2ValuesDisplay()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public CtrlLabel LblTitle1
		{
			get { return lblTitle1; }
			private set {  }
		}
		
		public CtrlLabel LblTitle2
		{
			get { return lblTitle2; }
			private set {  }
		}
		
		public CtrlLabel LblValue1
		{
			get { return lblValue1; }
			private set {  }
		}
		
		public CtrlLabel LblValue2
		{
			get { return lblValue2; }
			private set {  }
		}
	}
}
