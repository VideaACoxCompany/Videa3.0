using System;
using System.Collections.Generic;
using Videa.TrafficStatisticNS.Service.Proto.Types;

namespace Videa.TrafficStatisticNS.Service
{
	public static class ProtoExtensions
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static Videa.TrafficStatisticNS.Data.DataServices.RatePeriod ToEntity(this RatePeriod source)
		{
			return new Videa.TrafficStatisticNS.Data.DataServices.RatePeriod
			{
				RatePeriodHashKey = source.RatePeriodHashKey.ToCharArray(),
				RatePeriodSqn = source.RatePeriodSqn,
				RatePeriodName = source.RatePeriodName,
				RatePeriodStartDate = source.RatePeriodStartDate.ToDateTime(),
				RatePeriodEndDate = source.RatePeriodEndDate.ToDateTime()
			};

		}
		public  static Videa.TrafficStatisticNS.Data.DataServices.SellableInventoryTrafficStatistics ToEntity(this SellableInventoryTrafficStatistics source)
		{
			return new Videa.TrafficStatisticNS.Data.DataServices.SellableInventoryTrafficStatistics
			{
				SellableInventoryTrafficStatisticHashKey = source.SellableInventoryTrafficStatisticHashKey.ToCharArray(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				SellableInventoryTrafficStatisticSqn = source.SellableInventoryTrafficStatisticSqn,
				SellableInventoryAURValue = Decimal.Parse(source.SellableInventoryAURValue),
				RowVersion = source.RowVersion
			};

		}
		public  static Videa.TrafficStatisticNS.Data.DataServices.TrafficStatistic ToEntity(this TrafficStatistic source)
		{
			return new Videa.TrafficStatisticNS.Data.DataServices.TrafficStatistic
			{
				todo = source.todo
			};

		}
		#endregion Methods
	}
}
