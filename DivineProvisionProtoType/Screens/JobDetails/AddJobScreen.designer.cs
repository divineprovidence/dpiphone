// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace DivineProvisionProtoType
{
	[Register ("AddJobScreen")]
	partial class AddJobScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _addJobBtn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView _txtJobDescriptiobn { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtJobName { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField _txtJobReward { get; set; }

		[Action ("AddJobBtnClicked:")]
		partial void AddJobBtnClicked (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_txtJobName != null) {
				_txtJobName.Dispose ();
				_txtJobName = null;
			}

			if (_txtJobReward != null) {
				_txtJobReward.Dispose ();
				_txtJobReward = null;
			}

			if (_txtJobDescriptiobn != null) {
				_txtJobDescriptiobn.Dispose ();
				_txtJobDescriptiobn = null;
			}

			if (_addJobBtn != null) {
				_addJobBtn.Dispose ();
				_addJobBtn = null;
			}
		}
	}
}
