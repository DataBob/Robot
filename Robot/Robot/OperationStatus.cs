/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/8/2016
 * Time: 1:25 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Robot
{
	//public delegate void OperationStatusDelegate(OperationStatus newStatus);
	
	public enum enumOperationStatus
	{
		Started,
		Starting,
		Stopping,
		Stopped,
	}
	
	public class OperationStatusEventArgs : EventArgs
	{
	    public bool StartSuccess { get; set; }
	}
	
	
	/// <summary>
	/// Description of OperationStatus.
	/// </summary>
	public class OperationStatus
	{
		public enumOperationStatus OpStatus { get; private set; }
		
		public event EventHandler<OperationStatusEventArgs> StartRequested;
	
//		public event EventHandler Started;
		
		public event EventHandler StopRequested;
		
//		public event EventHandler Stopped;
		
		public OperationStatus()
		{
			OpStatus = enumOperationStatus.Stopped;
		}
		
		public void RequestStart()
		{
			if(OpStatus == enumOperationStatus.Stopped)
			{
				OpStatus = enumOperationStatus.Starting;
				OperationStatusEventArgs args = new OperationStatusEventArgs();
				StartRequested.Raise(this, args);
				if(args.StartSuccess)
				{
					OpStatus = enumOperationStatus.Started;
//					Started.Raise(this);
				}
				else
				{
					OpStatus = enumOperationStatus.Stopped;
				}
			}
		}
		
		
		public void RequestStop()
		{
			if(OpStatus == enumOperationStatus.Started)
			{
				OpStatus = enumOperationStatus.Stopping;
				StopRequested.Raise(this);
				OpStatus = enumOperationStatus.Stopped;
//				Stopped.Raise(this);
			}
		}
	}
}
