// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("ChooseLocation")]
	partial class ChooseLocation
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _cmdAddNewLocation { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView _listExistingLocations { get; set; }

		[Action ("AddNewLocationClicked:")]
		partial void AddNewLocationClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_cmdAddNewLocation != null) {
				_cmdAddNewLocation.Dispose ();
				_cmdAddNewLocation = null;
			}

			if (_listExistingLocations != null) {
				_listExistingLocations.Dispose ();
				_listExistingLocations = null;
			}
		}
	}
}
