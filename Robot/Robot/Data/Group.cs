/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 9:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Robot
{
	/// <summary>
	/// Description of IngredientsList.
	/// </summary>
	public class Group
	{
		[XmlAttribute("GroupID")]
    	public int _groupID { get; set; }
    	
		[XmlElement("Ingredient")] 
    	public readonly List<Ingredient> _ingredientList = new List<Ingredient>(); 
    	
		public Group()
		{
		}
	}
}
