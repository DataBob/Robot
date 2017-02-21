/*
 * Created by SharpDevelop.
 * User: User
 * Date: 4/2/2016
 * Time: 7:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml;
using System.Xml.Serialization;

namespace Robot
{
	/// <summary>
	/// Description of Ingredient.
	/// </summary>
	public class Ingredient
	{
		[XmlAttribute("IngredientID")]
		public int _ingredientID { get; set; }
		
		[XmlElement("Name")]
		public int _name { get; set; }
		
		[XmlElement("WeightValue")]
		public WeightValue _weightValue = new WeightValue();
		
		public Ingredient()
		{
		}
	}
}
