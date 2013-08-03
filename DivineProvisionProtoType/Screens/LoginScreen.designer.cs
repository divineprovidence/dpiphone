// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("LoginScreen")]
	partial class LoginScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdJobView { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton cmdLogin { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton cmdRegister { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView ImgLogoLogin { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtPassword { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField txtUserName { get; set; }

		[Action ("ClickEnterButton:")]
		partial void ClickEnterButton (MonoTouch.Foundation.NSObject sender);

		[Action ("ClickLogin:")]
		partial void ClickLogin (MonoTouch.Foundation.NSObject sender);

		[Action ("ClickRegister:")]
		partial void ClickRegister (MonoTouch.Foundation.NSObject sender);

		[Action ("JobViewClicked:")]
		partial void JobViewClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (cmdLogin != null) {
				cmdLogin.Dispose ();
				cmdLogin = null;
			}

			if (_cmdJobView != null) {
				_cmdJobView.Dispose ();
				_cmdJobView = null;
			}

			if (cmdRegister != null) {
				cmdRegister.Dispose ();
				cmdRegister = null;
			}

			if (ImgLogoLogin != null) {
				ImgLogoLogin.Dispose ();
				ImgLogoLogin = null;
			}

			if (txtPassword != null) {
				txtPassword.Dispose ();
				txtPassword = null;
			}

			if (txtUserName != null) {
				txtUserName.Dispose ();
				txtUserName = null;
			}
		}
	}
}
