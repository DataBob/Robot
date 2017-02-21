/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/7/2016
 * Time: 2:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Robot
{
	/// <summary>
	/// Description of GlobalVariables.
	/// </summary>
	public class GV
	{
		private static readonly GV _inst = new GV();
		
		private const string SerialPortComKey = "SerialPortComKey";
		
		public static GV Instance
	    {
	        get
	        {
	            return _inst;
	        }
	    }
		
		public readonly WeightValue TotalBalanceWeight = new WeightValue();
		
		public const int NB_INGREDIENTS = 7;
		
		public const int NB_GROUPS = 8;
		
		public GV()
		{
			
		}
		
		public string GetSerialPortCom()
		{
			string comPort = ConfigurationManager.AppSettings[SerialPortComKey];
			if (String.IsNullOrEmpty(comPort))
			{
			     Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
				 config.AppSettings.Settings.Add(SerialPortComKey, "COM3");
				 config.Save(ConfigurationSaveMode.Minimal);
				 return "COM3";
			}
			else
			{
				return comPort;
			}
		}
		
		public void SetSerialPortCom(string COM)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
			config.AppSettings.Settings.Remove(SerialPortComKey);
			config.AppSettings.Settings.Add(SerialPortComKey, COM);
			config.Save(ConfigurationSaveMode.Minimal);
		}
		
		
//		public  void UpdateWeight(double newWeight) 
//	    {
//	    	CurrentWeight.Set(newWeight);
//	        if (WeightChangedDel != null)
//	        {
//	            WeightChangedDel(CurrentWeight);
//	        }
//	    }
	}
}
