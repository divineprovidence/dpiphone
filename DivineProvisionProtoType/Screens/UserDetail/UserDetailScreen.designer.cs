// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("UserDetailScreen")]
	partial class UserDetailScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdLocationDetails { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _lblEmail { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _lblFirstName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _lblLastName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _lblLocation { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _lblUserName { get; set; }

		[Action ("LocationDetailsClicked:")]
		partial void LocationDetailsClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_imgLogo != null) {
				_imgLogo.Dispose ();
				_imgLogo = null;
			}

			if (_cmdLocationDetails != null) {
				_cmdLocationDetails.Dispose ();
				_cmdLocationDetails = null;
			}

			if (_lblEmail != null) {
				_lblEmail.Dispose ();
				_lblEmail = null;
			}

			if (_lblFirstName != null) {
				_lblFirstName.Dispose ();
				_lblFirstName = null;
			}

			if (_lblLastName != null) {
				_lblLastName.Dispose ();
				_lblLastName = null;
			}

			if (_lblLocation != null) {
				_lblLocation.Dispose ();
				_lblLocation = null;
			}

			if (_lblUserName != null) {
				_lblUserName.Dispose ();
				_lblUserName = null;
			}
		}
	}
}
