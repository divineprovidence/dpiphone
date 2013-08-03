using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Common;
namespace DivineProvisionProtoType
{
	public partial class AddJobScreen : UIViewController
	{
		private User _member;
		private ChooseLocation _chooseLocation; 
		public AddJobScreen () : base ("AddJobScreen", null)
		{
		}

		public AddJobScreen(User user): base ("AddJobScreen", null)
		{
			_member = user;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//handle return keyboard after we fill in reward
			this._txtJobReward.ShouldReturn = delegate(UITextField textField) {
				this._txtJobDescriptiobn.ResignFirstResponder ();
				return true;
			};

			//handle return keyboard after we fill in description
			this._txtJobDescriptiobn.ShouldBeginEditing = delegate(UITextView textField) {
				this._txtJobDescriptiobn.ResignFirstResponder ();
				//InsertJob ();
				return true;
			};

			this._txtJobDescriptiobn.ShouldEndEditing = delegate(UITextView textField) {
				this._txtJobDescriptiobn.ResignFirstResponder ();
				InsertJob ();
				return true;
			};
		}

		partial void AddJobBtnClicked (NSObject sender)
		{
			InsertJob();
		}
		private void InsertJob()
		{
			try
			{
				var job = new Job () 
				{
					JobName = _txtJobName.Text,
					JobDescription = _txtJobDescriptiobn.Text,
					Reward = _txtJobReward.Text,
					UserId = _member.UserId,
					IsDone = false,
					IsActive = true
				};
				if(_chooseLocation == null)
					_chooseLocation = new ChooseLocation(job);

				this.NavigationController.PushViewController(_chooseLocation,true);
			}
			catch(ArgumentException ex) {
				MsgBoxHelper.Show (ex.Message);
			}
		}
	}
}

