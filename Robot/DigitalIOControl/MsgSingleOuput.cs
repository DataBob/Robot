/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 2/7/2017
 * Time: 6:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using MccDaq;

namespace DigitalIOControl
{
	/// <summary>
	/// Description of Message.
	/// </summary>
	[Serializable]
	public class MsgSingleOuput : MessageType
	{		
		public DigitalPortType DigiPortType { get;  set; }
		
		public int OutputID { get;  set; }
		
		public DigitalLogicState DigiLogicState { get;  set; }
		
		public MsgSingleOuput(DigitalPortType digiPortType, int outputID, DigitalLogicState digiLogicState)
		{
			DigiPortType = digiPortType;
			OutputID = outputID;
			DigiLogicState = digiLogicState;
		}
		
		public MsgSingleOuput()
		{
			
		}
	}
	
	
}
