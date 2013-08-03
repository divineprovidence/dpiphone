// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("LocationDetailScreen")]
	partial class LocationDetailScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView _imgLogo { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtCity { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtCountry { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtGeoCode { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtLocationName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_imgLogo != null) {
				_imgLogo.Dispose ();
				_imgLogo = null;
			}

			if (_txtLocationName != null) {
				_txtLocationName.Dispose ();
				_txtLocationName = null;
			}

			if (_txtGeoCode != null) {
				_txtGeoCode.Dispose ();
				_txtGeoCode = null;
			}

			if (_txtCity != null) {
				_txtCity.Dispose ();
				_txtCity = null;
			}

			if (_txtCountry != null) {
				_txtCountry.Dispose ();
				_txtCountry = null;
			}
		}
	}
}
