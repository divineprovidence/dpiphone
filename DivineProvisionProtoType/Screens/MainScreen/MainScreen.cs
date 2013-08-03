using System;
using System.Drawing;
using System.Collections.Generic;

using Common;


using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace DivineProvisionProtoType
{
	public partial class MainScreen : UIViewController
	{
		private readonly User _user;
		private AddJobScreen _addjobScreen;

		public MainScreen () : base ("MainScreen", null)
		{
		}

		public MainScreen(User user) : base("MainScreen", null)
		{
			_user = user;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			_imgLogo.Image = ImageHelper.GetImageLogo ();
			LoadJobs ();
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden (false, animated);
		}

		partial void _AddJobBtnClicked (NSObject sender)
		{
			if(_addjobScreen == null)
				_addjobScreen = new AddJobScreen(_user);

			this.NavigationController.PushViewController(_addjobScreen,true);
		}

		private void LoadJobs()
		{
			var jobs = JobMockerHelper.GetJobsBasedOnUserId (_user.UserId);
			if (jobs != null) {
				ListJob.Source = new JobTableSource (jobs,_user, this.NavigationController);
			}

		}
	}
}

