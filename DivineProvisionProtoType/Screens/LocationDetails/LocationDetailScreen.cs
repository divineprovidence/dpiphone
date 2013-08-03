using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;

namespace DivineProvisionProtoType
{
	public partial class LocationDetailScreen : UIViewController
	{
		private readonly Location _location;
		public LocationDetailScreen () : base ("LocationDetailScreen", null)
		{
		}

		public LocationDetailScreen(Location location)
		{
			_location = location;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			LoadLocation ();
			_imgLogo.Image = ImageHelper.GetImageLogo ();

		}

		private void LoadLocation()
		{
			if (_location != null) {
				_txtLocationName.Text = _location.LocationName; _txtLocationName.Enabled = false;
				_txtGeoCode.Text = _location.GeoCode; _txtGeoCode.Enabled = false;
				_txtCity.Text = _location.City; _txtCity.Enabled = false;
				_txtCountry.Text = _location.Country; _txtCountry.Enabled = false;
			}
		}
	}
}

