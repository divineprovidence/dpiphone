// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("MainScreen")]
	partial class MainScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdAddJob { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView ListJob { get; set; }

		[Action ("_AddJobBtnClicked:")]
		partial void _AddJobBtnClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_imgLogo != null) {
				_imgLogo.Dispose ();
				_imgLogo = null;
			}

			if (ListJob != null) {
				ListJob.Dispose ();
				ListJob = null;
			}

			if (_cmdAddJob != null) {
				_cmdAddJob.Dispose ();
				_cmdAddJob = null;
			}
		}
	}
}
