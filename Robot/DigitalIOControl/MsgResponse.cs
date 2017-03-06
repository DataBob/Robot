/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 3/5/2017
 * Time: 1:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MccDaq;

namespace DigitalIOControl
{
	/// <summary>
	/// Description of MsgResponse.
	/// </summary>
	[Serializable]
	public class MsgResponse : MessageType
	{
		public ErrorInfo.ErrorCode ErrorCode {get; set; }	
		public MessageType Message {get; set; }	
		
		public MsgResponse()
		{
			
		}
	}
}
