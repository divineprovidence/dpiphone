using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;
namespace DivineProvisionProtoType
{
	public partial class JobDetailScreen : UIViewController
	{
		private readonly Job _job;
		private readonly User _user;
		private User _userposting;

		private  UserDetailScreen _userScreen;
		private LoginScreen _loginScreen;

		public JobDetailScreen () : base ("JobDetailScreen", null)
		{
		}

		/// <summary>
		/// constructor for public users, user do not need to login 
		/// </summary>
		/// <param name="job">Job.</param>
		public JobDetailScreen(Job job) : base("JobDetailScreen", null)
		{
			_job = job;
		}

		/// <summary>
		/// constructor for member users, user need to login
		/// </summary>
		/// <param name="job">Job.</param>
		/// <param name="user">User.</param>
		public JobDetailScreen(Job job, User user) : base("JobDetailScreen", null)
		{
			_job = job;
			_user = user;

		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			_imgJobLogo.Image = ImageHelper.GetImageLogo ();
			FillMember ();
			FillJobDetails ();
			LoadJobBids ();
		}

		partial void UserPostingClick (NSObject sender)
		{
			GoToUserDetail(_userposting);
		}

		partial void AddJobBidClicked (NSObject sender)
		{
			if (_user != null) {
				MsgBoxHelper.Show("Havent create add job screen yet");
			} else {
				MsgBoxHelper.Show (DPConstant.MemberOnly);

				if (_loginScreen == null)
					_loginScreen = new LoginScreen ();
				this.NavigationController.PushViewController (_loginScreen, true);
			}
		}

		partial void ViewJobBidsClicked (NSObject sender)
		{
			if (_user != null) {
				if (_userScreen == null)
					MsgBoxHelper.Show("Havent create view job bids screeen yet");
			} else {
				MsgBoxHelper.Show (DPConstant.MemberOnly);

				if (_loginScreen == null)
					_loginScreen = new LoginScreen ();
				this.NavigationController.PushViewController (_loginScreen, true);
			}
		}

		/// <summary>
		/// Fill all the job details in page attibrutess
		/// </summary>
		private void FillJobDetails()
		{
			if (_job != null) {
				_lblJobName.Text = _job.JobName;
				_lblJobDescription.Text = _job.JobDescription;

				_userposting = UserMockerHelper.GetUser (_job.UserId);
				_lblJobUserPostingUserName.Text = 
					_userposting != null ? "Posted by " +  _userposting.UserName : "";

				_lblJobUserPostingImage.Image = _userposting != null ? 
					ImageHelper.GetUserIcon() : null;
			}
		}

		private void FillMember()
		{
			if (_user != null) 
			{
				_lblMemberUserName.Text = "Welcome " + _user.UserName +", ";
				_imgMemberPicture.Image = ImageHelper.GetMemberIcon ();

			} else {
				_lblMemberUserName.Text = "";
					
			}
		}

		private void LoadJobBids()
		{
			var jobBids = JobBidMockerHelper.GetJobBidBasedOnJobId (_job.JobId);

			if (jobBids != null) 
			{
				_listJobBid.Source = new JobBidTableSource (jobBids, this.NavigationController);
			}
		}

		private void GoToUserDetail(User user)
		{
			if (_user != null) {
				if (_userScreen == null)
					_userScreen = new UserDetailScreen (user);
				this.NavigationController.PushViewController (_userScreen, true);
			} else {
				MsgBoxHelper.Show (DPConstant.MemberOnly);

				if (_loginScreen == null)
					_loginScreen = new LoginScreen ();
				this.NavigationController.PushViewController (_loginScreen, true);
			}

		}
	}
}

