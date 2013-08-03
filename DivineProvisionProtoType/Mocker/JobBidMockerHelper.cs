using System;
using System.Linq;

using System.Collections.Generic;

using Common;
namespace DivineProvisionProtoType
{
	public  static class JobBidMockerHelper
	{
		public static IList<JobBid> GetJobBidBasedOnJobId(int jobId)
		{
			return StaticMocker.JobBids.Where (w => w.JobId == jobId).ToList ();
		}
	}
}

