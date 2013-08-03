// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("JobsViewScreen")]
	partial class JobsViewScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdLogin { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView _listJobs { get; set; }

		[Action ("LoginButtonClicked:")]
		partial void LoginButtonClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_imgLogo != null) {
				_imgLogo.Dispose ();
				_imgLogo = null;
			}

			if (_cmdLogin != null) {
				_cmdLogin.Dispose ();
				_cmdLogin = null;
			}

			if (_listJobs != null) {
				_listJobs.Dispose ();
				_listJobs = null;
			}
		}
	}
}
