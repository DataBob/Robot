/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/9/2016
 * Time: 8:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Robot
{
	/// <summary>
	/// Description of MyConsole.
	/// </summary>
	public class MyConsole
	{
		private static MainForm frmMainForm;
		
		public MyConsole()
		{
			
		}
		
		public static void SetMainForm(MainForm frm)
		{
			frmMainForm = frm;
		}
		
		public static void WriteLine(string line)
		{
			//frmMainForm.WriteLineTextBox(line);
			Console.WriteLine(line);
		}
	}
}
