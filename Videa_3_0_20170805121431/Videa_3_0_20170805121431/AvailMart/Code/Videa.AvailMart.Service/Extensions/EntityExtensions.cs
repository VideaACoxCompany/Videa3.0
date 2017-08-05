using System;
using System.Collections.Generic;
using Videa.AvailMartNS.Service.Proto.Types;

namespace Videa.AvailMartNS.Service
{
	public static class EntityExtensions
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static AvailMart ToProto(this Videa.AvailMartNS.Data.DataServices.AvailMart source)
		{
			return new AvailMart
			{
				AvailMartHashKey = source.AvailMartHashKey.ToString(),
				AvailMartSqn = source.AvailMartSqn,
				StartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate),
				EndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate)
			};

		}
		public  static AvailList ToProto(this Videa.AvailMartNS.Data.DataServices.AvailList source)
		{
			return new AvailList
			{
				AvailListHashKey = source.AvailListHashKey.ToString(),
				AvailListSqn = source.AvailListSqn,
				AvailMartHashKey = source.AvailMartHashKey.ToString(),
				Name = source.Name,
				StartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate),
				EndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate)
			};

		}
		public  static AvailLineWithDetailedPeriods ToProto(this Videa.AvailMartNS.Data.DataServices.AvailLineWithDetailedPeriods source)
		{
			return new AvailLineWithDetailedPeriods
			{
				AvailLineWithDetailedPeriodsHashKey = source.AvailLineWithDetailedPeriodsHashKey.ToString(),
				AvailLineWithDetailedPeriodsSqn = source.AvailLineWithDetailedPeriodsSqn,
				AvailListHashKey = source.AvailListHashKey.ToString(),
				DaypartName = source.DaypartName,
				AvailName = source.AvailName
			};

		}
		public  static DetailedPeriod ToProto(this Videa.AvailMartNS.Data.DataServices.DetailedPeriod source)
		{
			return new DetailedPeriod
			{
				DetailedPeriodHashKey = source.DetailedPeriodHashKey.ToString(),
				DetailedPeriodSqn = source.DetailedPeriodSqn,
				AvailLineWithDetailedPeriodsHashKey = source.AvailLineWithDetailedPeriodsHashKey.ToString(),
				StartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.StartDate),
				EndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.EndDate),
				Rate = source.Rate.ToString()
			};

		}
		#endregion Methods
	}
}
