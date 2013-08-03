// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("AddLocationScreeen")]
	partial class AddLocationScreeen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdAddLocation { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtLocationCity { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtLocationCountry { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtLocationGeoCode { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtLocationName { get; set; }

		[Action ("AddLocationBtnClicked:")]
		partial void AddLocationBtnClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_txtLocationCity != null) {
				_txtLocationCity.Dispose ();
				_txtLocationCity = null;
			}

			if (_txtLocationCountry != null) {
				_txtLocationCountry.Dispose ();
				_txtLocationCountry = null;
			}

			if (_txtLocationGeoCode != null) {
				_txtLocationGeoCode.Dispose ();
				_txtLocationGeoCode = null;
			}

			if (_txtLocationName != null) {
				_txtLocationName.Dispose ();
				_txtLocationName = null;
			}

			if (_cmdAddLocation != null) {
				_cmdAddLocation.Dispose ();
				_cmdAddLocation = null;
			}
		}
	}
}
