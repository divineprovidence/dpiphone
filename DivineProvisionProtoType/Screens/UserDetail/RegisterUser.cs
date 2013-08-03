using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;

namespace DivineProvisionProtoType
{
	public partial class RegisterUser : UIViewController
	{
		private ChooseLocation _chooseLocation;
		private JobsViewScreen _jobViewScreen;

		public RegisterUser () : base ("RegisterUser", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//handle return keyboard after we fill in password
			this._txtLastName.ShouldReturn = delegate(UITextField textField) {
				this._txtLastName.ResignFirstResponder ();
				InsertUser();
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

		partial void RegisterUserClicked (NSObject sender)
		{
			InsertUser();
		}

		partial void JobViewClicked (NSObject sender)
		{
			if(_jobViewScreen == null)
				_jobViewScreen = new JobsViewScreen();
			this.NavigationController.PushViewController(_jobViewScreen,true);
		}

		private void InsertUser()
		{
			try
			{
				UserMockerHelper.InsertUser(
					new User()
				    {
						UserName = _txtUserName.Text,
						Password = _txtPassword.Text,
						Email = _txtEmail.Text,
						FirstName = _txtFirstName.Text,
						LastName = _txtLastName.Text
					});

				var user = StaticMocker.Users[StaticMocker.Users.Count -1];

				_chooseLocation = new ChooseLocation(user);
				this.NavigationController.PushViewController(_chooseLocation,true);

			}
			catch(ArgumentException ex)
			{
				MsgBoxHelper.Show(ex.Message);
			}
		}
	}
}

