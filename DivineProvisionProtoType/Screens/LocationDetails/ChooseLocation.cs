using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;
namespace DivineProvisionProtoType
{
	public partial class ChooseLocation : UIViewController
	{
		private readonly User _user;
		private readonly Job _job;
		private  AddLocationScreeen _addLocationScreen;

		public ChooseLocation () : base ("ChooseLocation", null)
		{
		}

		public ChooseLocation(User user) : base ("ChooseLocation", null)
		{
			_user = user;
		}

		public ChooseLocation(Job job) : base ("ChooseLocation", null)
		{
			_job = job;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			LoadLocations();
		}

		partial void AddNewLocationClicked (NSObject sender)
		{
			if(_addLocationScreen == null)
			{
				if(_user != null) _addLocationScreen = new AddLocationScreeen(_user);
				else if(_job != null) _addLocationScreen = new AddLocationScreeen(_job);

				this.NavigationController.PushViewController(_addLocationScreen,true);
			}
		}

		private void LoadLocations()
		{
			var locations = LocationMockerHelper.GetLocations();
			if (locations != null) {
				if (_user != null) 
				{
					_listExistingLocations.Source = new LocationTableSource (locations,
                                                     _user, this.NavigationController);
				} else  if(_job != null)
				{
					_listExistingLocations.Source = new LocationTableSource (locations,
                                                    _job, this.NavigationController);
				}
			}
		}
	}
}

