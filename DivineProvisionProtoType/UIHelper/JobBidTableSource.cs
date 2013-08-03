using System;
using System.Collections.Generic;

using MonoTouch.UIKit;
using MonoTouch.Foundation;

using Common;
namespace DivineProvisionProtoType
{
	public class JobBidTableSource : UITableViewSource
	{
		private IList<JobBid> _jobBids;
		private const string CELLIDENTIFIER = "TableCell";
		private UINavigationController _navigation;

		public JobBidTableSource (IList<JobBid> items, UINavigationController navigation)
		{
			_jobBids = items;
			_navigation = navigation;
		}


		public override int RowsInSection (UITableView tableview, int section)
		{
			return _jobBids.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CELLIDENTIFIER);

			if (cell == null) 
				cell = new UITableViewCell (UITableViewCellStyle.Default, CELLIDENTIFIER);

			var user = UserMockerHelper.GetUser(_jobBids[indexPath.Row].UserId);
			cell.TextLabel.Text = user.UserName + " : " +  
				_jobBids [indexPath.Row].JobBidComment.Substring(0,DPConstant.MaxCommentSummaryLength) + 
					" ... ";

			return cell;
		}

		/// <Docs>Table view containing the row.</Docs>
		/// <summary>
		/// will pointing to job bid details
		/// </summary>
		/// <param name="tableView">Table view.</param>
		/// <param name="indexPath">Index path.</param>
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{

			JobBidDetailScreen jobBidScreen = new JobBidDetailScreen(_jobBids[indexPath.Row]);

			_navigation.PushViewController(jobBidScreen,true);
		}
	}
}

