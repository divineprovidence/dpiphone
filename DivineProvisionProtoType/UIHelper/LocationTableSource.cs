using System;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;
namespace DivineProvisionProtoType
{
	public class LocationTableSource : UITableViewSource
	{
		private IList<Location> _locations;
		private User _user;
		private Job _job;
		private const string CELLIDENTIFIER = "TableCell";
		private UINavigationController _navigation;

		public LocationTableSource (IList<Location> locations,User user, UINavigationController navigation)
		{
			_locations = locations;
			_user = user;
			_navigation = navigation;
		}

		public LocationTableSource(IList<Location> locations, Job job, UINavigationController navigation)
		{
			_locations = locations;
			_job = job;
			_navigation = navigation;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _locations.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CELLIDENTIFIER);

			if (cell == null) 
				cell = new UITableViewCell (UITableViewCellStyle.Default, CELLIDENTIFIER);

			cell.TextLabel.Text = _locations [indexPath.Row].LocationName;
			return cell;
		}

		//will pointing to job details
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{

			if (_user != null) //if user means it from add user
			{
				UserMockerHelper.UpdateUserLocation (_user.UserId, _locations [indexPath.Row].LocationId);
				//_navigation.PopViewControllerAnimated(true);
				var loginScreen = new LoginScreen();
				_navigation.PushViewController(loginScreen,true);
			}
			if(_job != null) //if job means it from add job so go back to main screen
			{
				JobMockerHelper.UpdateJobLocation(_job.JobId, _locations [indexPath.Row].LocationId);

				//_navigation.PopViewControllerAnimated(true);
				var currentUser = UserMockerHelper.GetUser (_job.UserId);
				if(currentUser != null)
				{
					var mainScreen = new MainScreen(currentUser);
					_navigation.PushViewController(mainScreen,true);
				}
			}
		}
	
	
	}
}

