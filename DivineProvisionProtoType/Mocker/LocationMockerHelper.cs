using System;
using System.Linq;
using System.Collections.Generic;

using Common;
namespace DivineProvisionProtoType
{
	public static class LocationMockerHelper
	{
		public static Location GetLocation(int locationId)
		{
			return StaticMocker.Locations.SingleOrDefault (w => w.LocationId == locationId);
		}

		public static IList<Location> GetLocations()
		{
			return StaticMocker.Locations;
		}

		public static int InsertLocation(Location location)
		{
			ValidateLocation (location);
			ValidateLocationName (location.LocationName);
			ValidateLocationGeoCode (location.GeoCode);
			location.LocationId = StaticMocker.Locations.Count + 1;
			StaticMocker.Locations.Add (location);

			return location.LocationId;
		}

		public static void ValidateLocation(Location location)
		{
			if (location == null) 
				throw new ArgumentException ("Location object is null");
			if (string.IsNullOrEmpty (location.LocationName))
				throw new ArgumentException ("Location Name is empty");
			if(string.IsNullOrEmpty(location.GeoCode))
				throw new ArgumentException("Geocode is empty");
			if (string.IsNullOrEmpty (location.City))
				throw new ArgumentException ("City is empty");
			if (string.IsNullOrEmpty (location.Country))
				throw new ArgumentException ("Country is empty");
		}

		/// <summary>
		/// validate make sure location name is unique 
		/// </summary>
		/// <param name="locationName">Location name.</param>
		public static void ValidateLocationName(string locationName)
		{
			if (StaticMocker.Locations.Where (w => w.LocationName == locationName).Count() > 0)
				throw new ArgumentException ("Location Name is already exist");
		}

		/// <summary>
		/// validate make sure location geocode is unique
		/// </summary>
		/// <param name="geocode">Geocode.</param>
		public static void ValidateLocationGeoCode(string geocode)
		{
			if (StaticMocker.Locations.Where (w => w.GeoCode == geocode).Count() > 0)
				throw new ArgumentException ("Location geocode is already exist");
		}
	}
}

