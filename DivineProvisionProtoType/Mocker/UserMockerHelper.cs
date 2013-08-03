using System;
using System.Linq;
using System.Collections.Generic;

using Common;

namespace DivineProvisionProtoType
{
	public static class UserMockerHelper
	{
		public static Common.User Login(string username, string password)
		{
			return StaticMocker.Users.SingleOrDefault
				(w=>w.UserName == username && w.Password == password);
		}

		public static Common.User GetUser(int userId)
		{
			return StaticMocker.Users.SingleOrDefault
				(w => w.UserId == userId);
		}

		public static void InsertUser(User user)
		{
			if (user.UserId > 0)
				throw new ArgumentException ("user is already exist");

			ValidateUserName (user.UserName);

			if (string.IsNullOrEmpty (user.Password))
				throw new ArgumentException ("Password is empty");

			if (string.IsNullOrEmpty (user.Email))
				throw new ArgumentException ("Email is empty");

			user.UserId = StaticMocker.Users.Count () + 1;
			StaticMocker.Users.Add (user);
		}

		/// <summary>
		/// Validates the username make sure it is unique
		/// </summary>
		/// <param name="username">Username.</param>
		public static void ValidateUserName(string username)
		{
			if (StaticMocker.Users.Where(w=> w.UserName == username).Count() > 0)
			{
				throw new ArgumentException ("UserName is already exist in database");
			}

			if (string.IsNullOrEmpty (username))
				throw new ArgumentException ("Username is empty");
		}

		public static void UpdateUserLocation(int userId, int locationId)
		{
			foreach (var user in StaticMocker.Users) {
				if (user.UserId == userId) {
					user.LocationId = locationId;
					break;
				}
			}
		}

	}
}

