using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;

namespace DivineProvisionProtoType
{
	public partial class LoginScreen : UIViewController
	{
		private MainScreen _mainScreen;
		private RegisterUser _registerScreen;
		private JobsViewScreen _jobViewScreen;

		public LoginScreen () : base ("LoginScreen", null)
		{
			//test
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
		}

		/// <summary>
		/// Perform any additional setup after loading the view, typically from a nib.
		/// </summary>
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			ImgLogoLogin.Image = ImageHelper.GetImageLogo ();

			//handle return keyboard after we fill in password
			this.txtPassword.ShouldReturn = delegate(UITextField textField) {
				this.txtPassword.ResignFirstResponder ();
				Login ();
				return true;
			};
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

		#region Click Button

		/// <summary>
		/// Event handler when we click the login button
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ClickLogin (NSObject sender)
		{
			Login();
		}

		partial void ClickEnterButton (NSObject sender)
		{
			//Login ();
		}

		partial void JobViewClicked (NSObject sender)
		{
			if(_jobViewScreen == null)
			{
				//this.NavigationController.PopViewControllerAnimated(true);
				_jobViewScreen = new JobsViewScreen();
				this.NavigationController.PushViewController(_jobViewScreen,true);
			}
		}
		/// <summary>
		/// Event handler when we click the register button
		/// </summary>
		/// <param name="sender">Sender.</param>
		partial void ClickRegister (NSObject sender)
		{
			if(_registerScreen == null)
			{
				this.NavigationController.PopViewControllerAnimated(true);
				_registerScreen = new RegisterUser();
				this.NavigationController.PushViewController(_registerScreen,true);
			}
		}

		#endregion

		private void Login()
		{
			var user = UserMockerHelper.Login(txtUserName.Text, txtPassword.Text);
			if(user != null)
			{
				if(_mainScreen == null)
				{
					//this.NavigationController.PopViewControllerAnimated(true);
					_mainScreen = new MainScreen(user);
					this.NavigationController.PushViewController(_mainScreen,true);
				}
			}
			else
			{
				MsgBoxHelper.Show ("User name and password is incorrect");
			}
		}

	
	}

}

