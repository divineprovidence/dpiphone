// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("RegisterUser")]
	partial class RegisterUser
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdJobListView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton _cmdRegisterUser { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView _imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtEmail { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtFirstName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtLastName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtPassword { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtUserName { get; set; }

		[Action ("JobViewClicked:")]
		partial void JobViewClicked (MonoTouch.Foundation.NSObject sender);

		[Action ("RegisterUserClicked:")]
		partial void RegisterUserClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_cmdJobListView != null) {
				_cmdJobListView.Dispose ();
				_cmdJobListView = null;
			}

			if (_cmdRegisterUser != null) {
				_cmdRegisterUser.Dispose ();
				_cmdRegisterUser = null;
			}

			if (_imgLogo != null) {
				_imgLogo.Dispose ();
				_imgLogo = null;
			}

			if (_txtEmail != null) {
				_txtEmail.Dispose ();
				_txtEmail = null;
			}

			if (_txtPassword != null) {
				_txtPassword.Dispose ();
				_txtPassword = null;
			}

			if (_txtUserName != null) {
				_txtUserName.Dispose ();
				_txtUserName = null;
			}

			if (_txtFirstName != null) {
				_txtFirstName.Dispose ();
				_txtFirstName = null;
			}

			if (_txtLastName != null) {
				_txtLastName.Dispose ();
				_txtLastName = null;
			}
		}
	}
}
