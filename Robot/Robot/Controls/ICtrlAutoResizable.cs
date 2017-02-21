/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/10/2016
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Robot
{
	/// <summary>
	/// Description of ICtrlResizable.
	/// </summary>
	public interface ICtrlAutoResizable
	{
		int MaxLength { get; set; }
		
		void ResizeControlText();
	}
}
