/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 10:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of IngredientsBD.
	/// </summary>
	public class RecipesDB : IDisposable
	{
		private GroupsList _recipes = new GroupsList();
		
		readonly string _ingredientFileName;
		readonly string _directoryPath;
		
		public RecipesDB()
		{
			//string _directoryPath = Path.GetDirectoryName(Application.ExecutablePath);
			_directoryPath = @"c:\RobotData";
			_ingredientFileName = Path.Combine(_directoryPath, "Ingredients.xml");
			
			ReadFile();
		}
		
		public void Dispose()
		{
			//TODO
		}
		
		private void ReadFile()
		{
			try
			{
				using(TextReader reader = new StreamReader(_ingredientFileName))
				{
					XmlSerializer deserializer = new XmlSerializer(typeof(GroupsList));
					object obj = deserializer.Deserialize(reader);
					_recipes = (GroupsList)obj;;
				}
			}
			catch
			{
				bool exists = System.IO.Directory.Exists(_directoryPath);
				if(!exists)
			    	System.IO.Directory.CreateDirectory(_directoryPath);
				if(File.Exists(_ingredientFileName))
				{
					File.Delete(_ingredientFileName);
				}
				CreateFile();
			}
		}
		
		public void SaveFile()
		{
			Serialize();
		}
		
		private void CreateFile()
		{
			_recipes = new GroupsList();
			
			for(int i = 1; i <= GV.NB_GROUPS; i++)
			{
				Group gp = new Group();
				gp._groupID = i;
				_recipes._groupsList.Add(gp);
				for(int x = 1; x <= GV.NB_INGREDIENTS; x++)
				{
					Ingredient ing = new Ingredient();
					ing._ingredientID = x; 
					gp._ingredientList.Add(ing);
				}
			}	
			Serialize();
		}
		
		private void Serialize()
		{
		    XmlSerializer serializer = new XmlSerializer(typeof(GroupsList));
		    using ( TextWriter writer = new StreamWriter(_ingredientFileName))
		    {
		    	serializer.Serialize(writer, _recipes);
		    }  
		}
		
		public WeightValue GetWeightValue(int groupID, int ingredientID)
		{
			var groupItem = _recipes._groupsList.Find(x => x._groupID.Equals(groupID));
			var ingredientItem = groupItem._ingredientList.Find(x => x._ingredientID.Equals(ingredientID));
			return ingredientItem._weightValue;
		}
	}
}
