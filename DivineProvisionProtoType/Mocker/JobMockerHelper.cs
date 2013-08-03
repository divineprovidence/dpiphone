using System;
using System.Collections.Generic;
using System.Linq;

using Common;
namespace DivineProvisionProtoType
{
	public static class JobMockerHelper
	{
		public static IList<Job> GetJobsBasedOnUserId(int userId)
		{
			return StaticMocker.Jobs.Where (w => w.UserId == userId && w.IsActive)
									.OrderByDescending(w=>w.JobId).ToList ();
		}

		public static IList<Job> GetJobs()
		{
			return StaticMocker.Jobs.OrderByDescending(w=>w.JobId).ToList();
		}

		public static Job GetJob(int jobId)
		{
			return StaticMocker.Jobs.SingleOrDefault(w=> w.JobId == jobId);
		}

		public static void UpdateJobLocation(int jobId, int locationId)
		{
			foreach (var job in StaticMocker.Jobs) {
				if (job.JobId == jobId) {
					job.LocationId = locationId;
					break;
				}
			}
		}

		public static void InsertJob(Job job)
		{
			if (job.JobId > 0)
				throw new ArgumentException ("Job is exist");
			ValidateJobName (job.JobName);
			job.JobId = StaticMocker.Jobs.Count + 1;
			StaticMocker.Jobs.Add (job);
		}

		public static void ValidateJobName(string jobName)
		{
			if (StaticMocker.Jobs.Where (w => w.JobName == jobName).Count () > 0)
				throw new ArgumentException ("Job Name "+jobName+ " is already exist");

		}
	}
}

