using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;
namespace DivineProvisionProtoType
{
	public partial class JobBidDetailScreen : UIViewController
	{
		private readonly JobBid _jobBid;
		public JobBidDetailScreen () : base ("JobBidDetailScreen", null)
		{
		}

		public JobBidDetailScreen(JobBid jobbid)
		{
			_jobBid = jobbid;
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			_imgLogo.Image = ImageHelper.GetImageLogo ();

			LoadJobBids ();
		}

		private void LoadJobBids()
		{
			if (_jobBid != null) {
				_txtJobBidDescription.Text = _jobBid.JobBidComment;

				_lblJobName.Text = 
					JobMockerHelper.GetJob (_jobBid.JobId).JobName;

				_lblUserName.Text = UserMockerHelper.GetUser (_jobBid.UserId).UserName;

				_imgUserName.Image = ImageHelper.GetUserIcon ();

				_switchIsApproved.SetState (_jobBid.IsApproved, true);
				_switchIsApproved.Enabled = false;
			}
		}
	}
}

