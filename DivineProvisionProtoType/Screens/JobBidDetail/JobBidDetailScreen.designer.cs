// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("JobBidDetailScreen")]
	partial class JobBidDetailScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView _imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _imgUserName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _lblJobName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _lblUserName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch _switchIsApproved { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView _txtJobBidDescription { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_imgLogo != null) {
				_imgLogo.Dispose ();
				_imgLogo = null;
			}

			if (_imgUserName != null) {
				_imgUserName.Dispose ();
				_imgUserName = null;
			}

			if (_lblJobName != null) {
				_lblJobName.Dispose ();
				_lblJobName = null;
			}

			if (_lblUserName != null) {
				_lblUserName.Dispose ();
				_lblUserName = null;
			}

			if (_txtJobBidDescription != null) {
				_txtJobBidDescription.Dispose ();
				_txtJobBidDescription = null;
			}

			if (_switchIsApproved != null) {
				_switchIsApproved.Dispose ();
				_switchIsApproved = null;
			}
		}
	}
}
