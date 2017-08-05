using System;
using System.Collections.Generic;
using Videa.SellerRateNS.Service.Proto.Types;

namespace Videa.SellerRateNS.Service
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
		public  static RateTier ToProto(this Videa.SellerRateNS.Data.DataServices.RateTier source)
		{
			return new RateTier
			{
				RateTierHashKey = source.RateTierHashKey.ToString(),
				RateTierSqn = source.RateTierSqn,
				RateTierName = source.RateTierName
			};

		}
		public  static RatePeriod ToProto(this Videa.SellerRateNS.Data.DataServices.RatePeriod source)
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
		public  static SellableInventoryRate ToProto(this Videa.SellerRateNS.Data.DataServices.SellableInventoryRate source)
		{
			return new SellableInventoryRate
			{
				SellableInventoryRateHashKey = source.SellableInventoryRateHashKey.ToString(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				SellableInventoryRateSqn = source.SellableInventoryRateSqn,
				RateTierHashKey = source.RateTierHashKey.ToString(),
				RatePeriodHashKey = source.RatePeriodHashKey.ToString(),
				SellableInventoryRateValue = source.SellableInventoryRateValue.ToString(),
				RowVersion = source.RowVersion
			};

		}
		public  static Rate ToProto(this Videa.SellerRateNS.Data.DataServices.Rate source)
		{
			return new Rate
			{
				SellableInventoryRateValue = source.SellableInventoryRateValue.ToString(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				SellableInventoryRateHashKey = source.SellableInventoryRateHashKey.ToString(),
				RateTierHashKey = source.RateTierHashKey.ToString()
			};

		}
		#endregion Methods
	}
}
