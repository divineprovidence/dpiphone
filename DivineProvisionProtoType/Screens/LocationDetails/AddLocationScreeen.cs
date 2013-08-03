using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;
namespace DivineProvisionProtoType
{
	public partial class AddLocationScreeen : UIViewController
	{
		private readonly User _user;
		private readonly Job _job;

		public AddLocationScreeen () : base ("AddLocationScreeen", null)
		{
		}

		public AddLocationScreeen(User user) :  base ("AddLocationScreeen", null)
		{
			_user = user;
		}

		public AddLocationScreeen(Job job) : base ("AddLocationScreeen", null)
		{
			_job = job;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//handle return keyboard after we fill in password
			this._txtLocationCountry	.ShouldReturn = delegate(UITextField textField) {
				this._txtLocationCountry.ResignFirstResponder ();
				InsertLocation ();
				return true;
			};
		}

		private void InsertLocation()
		{
			int locationId = 0;
			try
			{
				locationId = LocationMockerHelper.InsertLocation (
							new Location () {
							LocationName = _txtLocationName.Text,
							GeoCode = _txtLocationGeoCode.Text,
							City = _txtLocationCity.Text,
							Country = _txtLocationCountry.Text
				});

				if (_user != null) //if user means it from add user
				{
					UserMockerHelper.UpdateUserLocation (_user.UserId, locationId);

					var loginScreen = new LoginScreen();
					this.NavigationController.PushViewController(loginScreen,true);
					//this.NavigationController.PopViewControllerAnimated(true);
				}
				if(_job != null) //if job means it from add job so go back to main screen
				{
					JobMockerHelper.UpdateJobLocation(_job.JobId, locationId);


					var currentUser = UserMockerHelper.GetUser (_job.UserId);
					if(currentUser != null)
					{
						var mainScreen = new MainScreen(currentUser);
						this.NavigationController.PushViewController(mainScreen,true);
						//this.NavigationController.PopViewControllerAnimated(true);
					}
				}
			}
			catch(ArgumentException ex) {
				MsgBoxHelper.Show (ex.Message);
			}
		}

		partial void AddLocationBtnClicked (NSObject sender)
		{
			InsertLocation();


		}
	}
}

