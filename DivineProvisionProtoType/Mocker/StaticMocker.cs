using System;
using System.Collections.Generic;

using Common;

namespace DivineProvisionProtoType
{
	public  static class StaticMocker
	{
		public static bool IsUsingMock{get;set;}

		public static List<User> Users{ get; set; }
		public static List<Job> Jobs{get;set;}
		public static List<JobBid> JobBids{ get; set; }
		public static List<Location> Locations{get;set;}

		public static void LoadMocks()
		{
			LoadUsers ();
			LoadLocations ();
			LoadJobs ();
			LoadJobBids ();
		}

		private static void LoadUsers()
		{
			if (Users == null) Users = new List<User> ();

			Users.Add (new User (1,"arif","arif","arif","liminto","arifliminto86@hotmail.com",1));
			Users.Add (new User (2,"haslim","haslim","haslim","wijaya","haslim@hotmail.com",2));
			Users.Add (new User (3,"rosi","rosi","rosi","wijaya","rosiwijaya@hotmail.com",3));
			Users.Add (new User (4,"ervina","ervina","ervina","wijaya","ervinahalim@yahoo.com",4));
		}

		private static void LoadLocations()
		{
			if (Locations == null) Locations = new List<Location> ();

			Locations.Add(new Location(1,"VicPark","fasd","Perth","Australia"));
			Locations.Add(new Location(2,"Wintrop","fasd","Perth","Australia"));
			Locations.Add(new Location(3,"Garbo","fasd","Perth","Australia"));
			Locations.Add(new Location(4,"Belmont","fasd","Perth","Australia"));
		}

		private static void LoadJobs()
		{
			if (Jobs == null) Jobs = new List<Job> ();

			Jobs.Add (new Job (1, "Buy Meat",
			                   "Through the five games, McLemore might have gone just 26-for-78 from the floor (33.3 percent) and he’ll have to figure out the NBA 3-point distance after going just 7-for-36 (19.4 percent), but he also scored 26 points in a game against Toronto to go with Friday’s 27 on 10-for-21 shooting. Take away his errant 3-ball and and he was 8-for-13 from inside the arc.", 
			                   1, false, 2, "medalion", true, 10));

			Jobs.Add (new Job (2, "Clean House",
			                   "At 6-foot-5 — and he’ll beef up his 195-pound frame — McLemore has the size coaches love at the 2, and he showed off his ability to run the floor and finish with thunderous jams that lifted special guest DeMarcus Cousins out of his seat on the bench. More impressive was the patience he showed on offense to put the ball on the floor", 
			                   1, false, 3, "money 20 bucks", true, 10));

			Jobs.Add (new Job (3, "Cook Vegi",
			                   "“He’s a great kid and he’s working his butt off,” Malone said. “He’s given great focus and he’s willing to learn. At breakfast with him [Thursday], the big thing was keep your head up, don’t get down on yourself; we still love you",
			                   3, false, 1, "medalion", true, 10));

			Jobs.Add (new Job (4, "Dog Walk",
			                   "",
			                   3, false, 4, "branded watch", true, 10));

			Jobs.Add (new Job (5, "Write Report",
			                   "“He’s a great kid and he’s working his butt off,” Malone said. “He’s given great focus and he’s willing to learn. At breakfast with him [Thursday], the big thing was keep your head up, don’t get down on yourself; we still love you",
			                   1, false, 1, "bags", true, 10));

			Jobs.Add (new Job (6, "Code Ios",
			                   "“He’s a great kid and he’s working his butt off,” Malone said. “He’s given great focus and he’s willing to learn. At breakfast with him [Thursday], the big thing was keep your head up, don’t get down on yourself; we still love you",
			                   1, false, 1, "bags", true, 10));

			Jobs.Add (new Job (7, "Buy Coffee",
			                   "",
			                   2, false, 1, "bags", true, 10));


		}

		private static void LoadJobBids()
		{
			if (JobBids == null) JobBids = new List<JobBid> ();

			JobBids.Add (new JobBid (1, 1, 2, false, 100, 
			                         "The rest of the old 2010 class is being replaced by younger versions, as Nick Young becomes the new Shannon Brown, Wesley Johnson is now Metta World Peace 2.0 (or possibly -2.0), and Robert Sacre turns into Adam Morrison, D.J. Mbenga and Luke Walton all rolled into one."));

			JobBids.Add (new JobBid (2, 1, 3, true, 60, 
			                         "Of course, for this to make sense, you've got to ignore the fact that Bryant is hobbling on a surgically repaired Achilles tendon, Gasol missed 33 games last season, and everybody involved will be four years older by the end of the year. "));

			JobBids.Add (new JobBid (3, 1, 4, false, 120, 
			                         "I can buy  wagyu meat and cook for you for free"));

			JobBids.Add (new JobBid (4, 3, 1, true, 100, 
			                         "I can buy and cook"));

			JobBids.Add (new JobBid (5, 3, 2, false, 60, 
			                         "after work i can la "));

			JobBids.Add (new JobBid (6, 3, 4, false, 120, 
			                         "I buy from restaurant"));

		}
	}
}

