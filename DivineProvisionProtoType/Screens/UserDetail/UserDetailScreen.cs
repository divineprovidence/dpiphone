using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;

namespace DivineProvisionProtoType
{
	public partial class UserDetailScreen : UIViewController
	{
		private User _user;
		private LocationDetailScreen _locationScreen = null;
		public UserDetailScreen () : base ("UserDetailScreen", null)
		{
		}

		public UserDetailScreen(User user) : base("UserDetailScreen", null)
		{
			_user = user;
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{

			base.ViewDidLoad ();
			_imgLogo.Image = ImageHelper.GetImageLogo ();
			LoadUser ();
		}

		private void LoadUser()
		{
			_lblUserName.Text = _user.UserName; _lblUserName.Enabled = false;
			_lblFirstName.Text = _user.FirstName; _lblFirstName.Enabled = false;
			_lblLastName.Text = _user.LastName; _lblLastName.Enabled = false;
			_lblEmail.Text = _user.Email; _lblEmail.Enabled = false;

			_lblLocation.Text = LocationMockerHelper.GetLocation (_user.LocationId).LocationName;
			_lblLocation.Enabled = false;
		}

		partial void LocationDetailsClicked (NSObject sender)
		{
			if(_locationScreen == null)
			{
				var location = LocationMockerHelper.GetLocation(_user.LocationId);
				_locationScreen = new LocationDetailScreen (location);
			}
			this.NavigationController.PushViewController(_locationScreen,true);
		}
	}
}

