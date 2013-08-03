using System;

namespace Common
{
	public class Location
	{
		public int LocationId{ get; set;}
		public string LocationName{ get; set;}
		public string GeoCode{ get; set;}
		public string City{ get; set;}
		public string Country{ get; set;}

		public Location ()
		{
		}

		public Location(int locationId, string locationName, string geoCode,
		                string city, string country)
		{
			LocationId = locationId;
			LocationName = locationName;
			GeoCode = geoCode;
			City = city;
			Country = country;
		}
	}
}

