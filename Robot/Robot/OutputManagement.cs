/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 7/25/2016
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MccDaq;
using System.Threading;
using System.Collections.Generic;


namespace Robot
{
	/// <summary>
	/// Description of OutputManagement.
	/// </summary>
	public class OutputManagement : IDisposable
	{
		bool BoardConnected { get; set; }
		
//		public bool BoardFound
//		{
//			get
//			{
//				return _boardFound;
//			}
//		}
		
		readonly IOCommunication _ioCom;
		
		readonly  bool[] _ingredientStatus = new bool[8];
              
		public OutputManagement()
		{
			_ioCom = new IOCommunication();
			//TODO check connection
			BoardConnected =true;
		}
		
		public void Dispose()
		{		
			SetAllIngredientOff();
			_ioCom.Dispose();
		}
		
			
		private void SetOn(int outputID)
		{
			if(outputID >=0 && outputID <= 7)
			{
				_ingredientStatus[outputID] = true;
				if(!BoardConnected)
					return;
				_ioCom.SendSetOneOutput(DigitalPortType.FirstPortA, outputID, DigitalLogicState.High);
			}
			else
			{
				//TODO error
			}
		}
		
		private void SetOff(int outputID)
		{
			if(outputID >=0 && outputID <= 7)
			{
				_ingredientStatus[outputID] = false;
				if(!BoardConnected)
					return;
				_ioCom.SendSetOneOutput(DigitalPortType.FirstPortA, outputID, DigitalLogicState.Low);
			}
			else
			{
				//TODO error
			}
		}
		
		public void SetIngredientOn(int ingredientID)
		{
			
		//	SimpleLogger.Logger.Log(String.Format("SetIngredientOn: {0}", ingredientID));
			lock(this)
			{
				if(!BoardConnected)
					return;
				SetOn(ingredientID - 1);
			}
//			SimpleLogger.Logger.Log("Leave SetIngredientOn");
		}
		
		public void SetIngredientOff(int ingredientID)
		{
//			SimpleLogger.Logger.Log(String.Format("SetIngredientOff: {0}", ingredientID));
			lock(this)
			{
				if(!BoardConnected)
					return;
				SetOff(ingredientID - 1);
			}
//			SimpleLogger.Logger.Log("Leave SetIngredientOff");
		}
		
		public void SetAllIngredientOff()
		{
		//	SimpleLogger.Logger.Log("Enter SetAllIngredientOff");
			lock(this)
			{
				for(var i = 0; i < _ingredientStatus.Length; i++)
				{
					_ingredientStatus[i] = false;
				}
				if(!BoardConnected)
					return;
				_ioCom.SendSetAllOff();
			}
//			SimpleLogger.Logger.Log("Leave SetAllIngredientOff");
		}			
	}
}
