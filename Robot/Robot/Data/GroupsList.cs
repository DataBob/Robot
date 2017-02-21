/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 10:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Robot
{
	/// <summary>
	/// Description of GroupsList.
	/// </summary>
	[XmlRoot("Root")]
	public class GroupsList
	{
		[XmlElement("Group")] 
    	public readonly List<Group> _groupsList = new List<Group>(); 
    	
		public GroupsList()
		{
		}
	}
}
