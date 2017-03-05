/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 7/12/2016
 * Time: 2:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;

namespace Robot
{
	public delegate void WeightChangedDelegate(WeightValue newWeight); //delegate type definition
	
	/// <summary>
	/// Description of WeightValue.
	/// </summary>
	public class WeightValue
	{
		private int _value = 0;
		
		[XmlIgnore]
		public WeightChangedDelegate WeightChangedDel; //delegate instance. Detail view will "subscribe" to this.
		
		[XmlElement("Value")]
		public int Value
	    {
			get
			{
				//lock(this)
				{
			    	return _value;
				}
			}
			
			set
			{
				//lock(this)
				{
				    _value = value;
					if (WeightChangedDel != null)
			        {
			            WeightChangedDel(this);
			        }
				}
			}
	    }
		
		public string FormatKg()
		{
			return Value.ToString() + " KG";
		}
		
		public void AppendNumberRight(int number)
		{
			Debug.Assert(number >= 0 && number <= 9);
			if(_value <= 999)
				Value = _value * 10 + number;
		}
		
		public void HandleKey(PadCommand keyParam)
		{
			var resultString = Regex.Match(keyParam.ToString(), @"\d+").Value;
			
			int number;
			if(int.TryParse(resultString, out number))
			{
				AppendNumberRight(number);
			}
			else if(keyParam == PadCommand.del)
			{
				Value = 0;
			}
		
		}
	}
}
