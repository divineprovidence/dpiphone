using System;

namespace Common
{
	public class JobBid
	{
		public int JobBidId{get;set;}
		public int JobId{get;set;}
		public int UserId{get;set;}
		public bool IsApproved{get;set;}
		public int PriceBid{ get; set;}
		public string JobBidComment{ get; set;}

		public JobBid()
		{
		}

		public JobBid(int jobBidId, int jobId, int userId, bool isApproved,
		              int priceBid, string jobBidComment)
		{
			JobBidId = JobBidId;
			JobId = jobId;
			UserId = userId;
			IsApproved = isApproved;
			PriceBid = priceBid;
			JobBidComment = jobBidComment;
		}
	}
}

