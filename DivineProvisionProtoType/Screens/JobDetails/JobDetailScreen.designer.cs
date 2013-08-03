// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("JobDetailScreen")]
	partial class JobDetailScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdAddJobBid { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton _cmdUserPostingButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton _cmdViewJobBids { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _imgJobLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _imgMemberPicture { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView _lblJobDescription { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _lblJobName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _lblJobUserPostingImage { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _lblJobUserPostingUserName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _lblMemberUserName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView _listJobBid { get; set; }

		[Action ("AddJobBidClicked:")]
		partial void AddJobBidClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("UserPostingClick:")]
		partial void UserPostingClick (MonoTouch.Foundation.NSObject sender);

		[Action ("ViewJobBidsClicked:")]
		partial void ViewJobBidsClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_cmdViewJobBids != null) {
				_cmdViewJobBids.Dispose ();
				_cmdViewJobBids = null;
			}

			if (_cmdAddJobBid != null) {
				_cmdAddJobBid.Dispose ();
				_cmdAddJobBid = null;
			}

			if (_cmdUserPostingButton != null) {
				_cmdUserPostingButton.Dispose ();
				_cmdUserPostingButton = null;
			}

			if (_imgJobLogo != null) {
				_imgJobLogo.Dispose ();
				_imgJobLogo = null;
			}

			if (_imgMemberPicture != null) {
				_imgMemberPicture.Dispose ();
				_imgMemberPicture = null;
			}

			if (_lblJobDescription != null) {
				_lblJobDescription.Dispose ();
				_lblJobDescription = null;
			}

			if (_lblJobName != null) {
				_lblJobName.Dispose ();
				_lblJobName = null;
			}

			if (_lblJobUserPostingImage != null) {
				_lblJobUserPostingImage.Dispose ();
				_lblJobUserPostingImage = null;
			}

			if (_lblJobUserPostingUserName != null) {
				_lblJobUserPostingUserName.Dispose ();
				_lblJobUserPostingUserName = null;
			}

			if (_lblMemberUserName != null) {
				_lblMemberUserName.Dispose ();
				_lblMemberUserName = null;
			}

			if (_listJobBid != null) {
				_listJobBid.Dispose ();
				_listJobBid = null;
			}
		}
	}
}
