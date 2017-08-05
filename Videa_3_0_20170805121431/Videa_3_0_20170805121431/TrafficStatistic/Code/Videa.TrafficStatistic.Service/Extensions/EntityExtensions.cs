using System;
using System.Collections.Generic;
using Videa.TrafficStatisticNS.Service.Proto.Types;

namespace Videa.TrafficStatisticNS.Service
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
		public  static RatePeriod ToProto(this Videa.TrafficStatisticNS.Data.DataServices.RatePeriod source)
		{
			return new RatePeriod
			{
				RatePeriodHashKey = source.RatePeriodHashKey.ToString(),
				RatePeriodSqn = source.RatePeriodSqn,
				RatePeriodName = source.RatePeriodName,
				RatePeriodStartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.RatePeriodStartDate),
				RatePeriodEndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.RatePeriodEndDate)
			};

		}
		public  static SellableInventoryTrafficStatistics ToProto(this Videa.TrafficStatisticNS.Data.DataServices.SellableInventoryTrafficStatistics source)
		{
			return new SellableInventoryTrafficStatistics
			{
				SellableInventoryTrafficStatisticHashKey = source.SellableInventoryTrafficStatisticHashKey.ToString(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				SellableInventoryTrafficStatisticSqn = source.SellableInventoryTrafficStatisticSqn,
				SellableInventoryAURValue = source.SellableInventoryAURValue.ToString(),
				RowVersion = source.RowVersion
			};

		}
		public  static TrafficStatistic ToProto(this Videa.TrafficStatisticNS.Data.DataServices.TrafficStatistic source)
		{
			return new TrafficStatistic
			{
				todo = source.todo
			};

		}
		#endregion Methods
	}
}
