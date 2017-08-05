using System;
using System.Collections.Generic;
using Videa.SharebuilderRateNS.Service.Proto.Types;

namespace Videa.SharebuilderRateNS.Service
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
		public  static Videa.SharebuilderRateNS.Data.DataServices.RateTier ToEntity(this RateTier source)
		{
			return new Videa.SharebuilderRateNS.Data.DataServices.RateTier
			{
				RateTierHashKey = source.RateTierHashKey.ToCharArray(),
				RateTierSqn = source.RateTierSqn,
				RateTierName = source.RateTierName
			};

		}
		public  static Videa.SharebuilderRateNS.Data.DataServices.RatePeriod ToEntity(this RatePeriod source)
		{
			return new Videa.SharebuilderRateNS.Data.DataServices.RatePeriod
			{
				RatePeriodHashKey = source.RatePeriodHashKey.ToCharArray(),
				RatePeriodSqn = source.RatePeriodSqn,
				RatePeriodName = source.RatePeriodName,
				RatePeriodStartDate = source.RatePeriodStartDate.ToDateTime(),
				RatePeriodEndDate = source.RatePeriodEndDate.ToDateTime()
			};

		}
		public  static Videa.SharebuilderRateNS.Data.DataServices.SellableInventoryRate ToEntity(this SellableInventoryRate source)
		{
			return new Videa.SharebuilderRateNS.Data.DataServices.SellableInventoryRate
			{
				SellableInventoryRateHashKey = source.SellableInventoryRateHashKey.ToCharArray(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				SellableInventoryRateSqn = source.SellableInventoryRateSqn,
				RateTierHashKey = source.RateTierHashKey.ToCharArray(),
				SellableInventoryRateValue = Decimal.Parse(source.SellableInventoryRateValue),
				RowVersion = source.RowVersion
			};

		}
		public  static Videa.SharebuilderRateNS.Data.DataServices.Rate ToEntity(this Rate source)
		{
			return new Videa.SharebuilderRateNS.Data.DataServices.Rate
			{
				todo = source.todo
			};

		}
		#endregion Methods
	}
}
