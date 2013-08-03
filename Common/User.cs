using System;


namespace Common
{
	public class User
	{
		public int UserId{ get; set; }

		public string UserName{ get; set; }

		public string Password{ get; set; }

		public string FirstName{ get; set; }

		public string LastName{ get; set; }

		public string Email{ get; set; }

		public int LocationId{ get; set; }

		public User()
		{

		}

		public User(int userid, string username, string password, string firstname, 
		            string lastname, string email,int locationId)
		{
			UserId = userid;
			UserName = username;
			Password = password;
			FirstName = firstname;
			LastName = lastname;
			Email = email;
			LocationId = locationId;
		}



	}
}

