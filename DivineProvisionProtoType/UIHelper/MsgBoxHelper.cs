using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	public  static class MsgBoxHelper
	{
		public static void Show(string message) 
		{
			new UIAlertView ("Divine Provision Message", message, null, "ok", null).Show ();
		}
	}
}

