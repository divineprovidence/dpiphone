using System;
using System.Drawing;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;

namespace DivineProvisionProtoType
{
	public partial class JobsViewScreen : UIViewController
	{
		private LoginScreen _loginScreen;
		public JobsViewScreen () : base ("JobsViewScreen", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			LoadJobs ();
		}

		partial void LoginButtonClicked (NSObject sender)
		{
			if(_loginScreen == null)
				_loginScreen = new LoginScreen();

			this.NavigationController.PushViewController(_loginScreen,true);
		}

		private void LoadJobs()
		{
			var jobs = JobMockerHelper.GetJobs ();
			if (jobs != null) {
				_listJobs.Source = new JobTableSource (jobs, this.NavigationController);
			}

		}
	}
}

