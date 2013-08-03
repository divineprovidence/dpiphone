using System;

namespace Common
{
	public class Job
	{
		public int JobId{ get; set; }
		public string JobName {get;set;}
		public string JobDescription{ get; set; }
		public int UserId{get;set;}
		public bool IsDone{get;set;}
		public int LocationId{get;set;}
		public string Reward{get;set;}
		public bool IsActive{get;set;}
		public int DurationDays{get;set;}

		public Job()
		{
		}

		public Job(int jobId, string jobName, string jobDescription, 
		           int userId, bool isDone, int locationId,
		           string reward, bool isActive, int durationDays)
		{
			JobId = jobId;
			JobName = jobName;
			JobDescription = jobDescription;
			UserId = userId;
			IsDone = isDone;
			LocationId = locationId;
			Reward = reward;
			IsActive = isActive;
			DurationDays = durationDays;
		}
	}
}

