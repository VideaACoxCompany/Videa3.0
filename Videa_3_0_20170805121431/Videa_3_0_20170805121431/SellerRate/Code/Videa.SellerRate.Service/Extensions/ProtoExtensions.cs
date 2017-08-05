using System;
using System.Collections.Generic;
using Videa.SellerRateNS.Service.Proto.Types;

namespace Videa.SellerRateNS.Service
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
		public  static Videa.SellerRateNS.Data.DataServices.RateTier ToEntity(this RateTier source)
		{
			return new Videa.SellerRateNS.Data.DataServices.RateTier
			{
				RateTierHashKey = source.RateTierHashKey.ToCharArray(),
				RateTierSqn = source.RateTierSqn,
				RateTierName = source.RateTierName
			};

		}
		public  static Videa.SellerRateNS.Data.DataServices.RatePeriod ToEntity(this RatePeriod source)
		{
			return new Videa.SellerRateNS.Data.DataServices.RatePeriod
			{
				RatePeriodHashKey = source.RatePeriodHashKey.ToCharArray(),
				RatePeriodSqn = source.RatePeriodSqn,
				RatePeriodName = source.RatePeriodName,
				RatePeriodStartDate = source.RatePeriodStartDate.ToDateTime(),
				RatePeriodEndDate = source.RatePeriodEndDate.ToDateTime()
			};

		}
		public  static Videa.SellerRateNS.Data.DataServices.SellableInventoryRate ToEntity(this SellableInventoryRate source)
		{
			return new Videa.SellerRateNS.Data.DataServices.SellableInventoryRate
			{
				SellableInventoryRateHashKey = source.SellableInventoryRateHashKey.ToCharArray(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				SellableInventoryRateSqn = source.SellableInventoryRateSqn,
				RateTierHashKey = source.RateTierHashKey.ToCharArray(),
				RatePeriodHashKey = source.RatePeriodHashKey.ToCharArray(),
				SellableInventoryRateValue = Decimal.Parse(source.SellableInventoryRateValue),
				RowVersion = source.RowVersion
			};

		}
		public  static Videa.SellerRateNS.Data.DataServices.Rate ToEntity(this Rate source)
		{
			return new Videa.SellerRateNS.Data.DataServices.Rate
			{
				SellableInventoryRateValue = Decimal.Parse(source.SellableInventoryRateValue),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				SellableInventoryRateHashKey = source.SellableInventoryRateHashKey.ToCharArray(),
				RateTierHashKey = source.RateTierHashKey.ToCharArray()
			};

		}
		#endregion Methods
	}
}
