using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
namespace DivineProvisionProtoType
{
	public static class ImageHelper
	{
		public static UIImage GetImageLogo()
		{
			return UIImage.FromFile (DPConstant.LoginImageLocationConstant);
		}

		public static UIImage GetUserIcon()
		{
			return UIImage.FromFile (DPConstant.UserImageLocationConstant);
		}

		public static UIImage GetMemberIcon()
		{
			return UIImage.FromFile (DPConstant.MemberImageLocationConstant);
		}

	}
}

