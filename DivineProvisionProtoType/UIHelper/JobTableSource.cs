using System;
using System.Collections.Generic;

using MonoTouch.UIKit;
using MonoTouch.Foundation;

using Common;

namespace DivineProvisionProtoType
{
	public class JobTableSource : UITableViewSource
	{
		private IList<Job> _jobs;
		private User _member;
		private const string CELLIDENTIFIER = "TableCell";
		private UINavigationController _navigation;

		public JobTableSource (IList<Job> items, UINavigationController navigation)
		{
			_jobs = items;
			_navigation = navigation;
		}

		public JobTableSource(IList<Job> items, User user,UINavigationController navigation)
		{
			_jobs = items;
			_member = user;
			_navigation = navigation;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return _jobs.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CELLIDENTIFIER);

			if (cell == null) 
				cell = new UITableViewCell (UITableViewCellStyle.Default, CELLIDENTIFIER);

			cell.TextLabel.Text = _jobs [indexPath.Row].JobName;
			return cell;
		}

		//will pointing to job details
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			JobDetailScreen jobscreen = null;
			if(_member != null)
				jobscreen = new JobDetailScreen (_jobs[indexPath.Row], _member);
			else
				jobscreen = new JobDetailScreen(_jobs[indexPath.Row]);

			_navigation.PushViewController(jobscreen,true);
		}
	}
}

