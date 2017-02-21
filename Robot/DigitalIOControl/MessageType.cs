/*
 * Created by SharpDevelop.
 * User: stanguay
 * Date: 2/7/2017
 * Time: 7:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Xml.Serialization;

namespace DigitalIOControl
{
	/// <summary>
	/// Description of IMessage.
	/// </summary>
	/// 
	[XmlInclude(typeof(MsgSingleOuput))]
	[XmlInclude(typeof(MsgPing))]
	[XmlInclude(typeof(MsgTurnAllOff))]
	[XmlInclude(typeof(MsgExit))]
	[Serializable]
	public class MessageType
	{
		
	}
}
