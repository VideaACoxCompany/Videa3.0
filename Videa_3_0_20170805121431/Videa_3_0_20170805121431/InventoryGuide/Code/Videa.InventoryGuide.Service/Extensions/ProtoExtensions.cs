using System;
using System.Collections.Generic;
using Videa.InventoryGuideNS.Service.Proto.Types;

namespace Videa.InventoryGuideNS.Service
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
		public  static Videa.InventoryGuideNS.Data.DataServices.SellingTitle ToEntity(this SellingTitle source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.SellingTitle
			{
				SellingTitleHashKey = source.SellingTitleHashKey.ToCharArray(),
				SellingTitleSqn = source.SellingTitleSqn,
				SellingTitleName = source.SellingTitleName,
				SellingTitleStartDate = source.SellingTitleStartDate.ToDateTime(),
				SellingTitleEndDate = source.SellingTitleEndDate.ToDateTime()
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.Station ToEntity(this Station source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.Station
			{
				StationHashKey = source.StationHashKey.ToCharArray(),
				StationSqn = source.StationSqn,
				StationName = source.StationName,
				StationCallLetters = source.StationCallLetters
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.StationGroup ToEntity(this StationGroup source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.StationGroup
			{
				StationGroupHashKey = source.StationGroupHashKey.ToCharArray(),
				StationGroupSqn = source.StationGroupSqn,
				StationGroupName = source.StationGroupName
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.RateCard ToEntity(this RateCard source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.RateCard
			{
				RateCardHashKey = source.RateCardHashKey.ToCharArray(),
				RateCardSqn = source.RateCardSqn,
				RateCardName = source.RateCardName,
				RateCardStartDate = source.RateCardStartDate.ToDateTime(),
				RateCardEndDate = source.RateCardEndDate.ToDateTime()
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.RateCardDaypart ToEntity(this RateCardDaypart source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.RateCardDaypart
			{
				RateCardDaypartHashKey = source.RateCardDaypartHashKey.ToCharArray(),
				RateCardDaypartSqn = source.RateCardDaypartSqn,
				RateCardDaypartName = source.RateCardDaypartName
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.RateCardType ToEntity(this RateCardType source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.RateCardType
			{
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToCharArray(),
				RateCardTypeSqn = source.RateCardTypeSqn,
				RateCardTypeName = source.RateCardTypeName
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.SellingTitleTimeRange ToEntity(this SellingTitleTimeRange source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.SellingTitleTimeRange
			{
				SellingTitleTimeRangeHashKey = source.SellingTitleTimeRangeHashKey.ToCharArray(),
				TimeRangeSqn = source.TimeRangeSqn,
				SellingTitleTimeRangeName = source.SellingTitleTimeRangeName
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.SellingTitleDaysOfWeek ToEntity(this SellingTitleDaysOfWeek source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.SellingTitleDaysOfWeek
			{
				SellingTitleDaysOfWeekHashKey = source.SellingTitleDaysOfWeekHashKey.ToCharArray(),
				SellingTitleDaysOfWeekSqn = source.SellingTitleDaysOfWeekSqn,
				SellingTitleDaysOfWeekName = source.SellingTitleDaysOfWeekName,
				Mon = source.Mon,
				Tue = source.Tue,
				Wed = source.Wed,
				Thu = source.Thu,
				Fri = source.Fri,
				Sat = source.Sat,
				Sun = source.Sun
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.RatePeriod ToEntity(this RatePeriod source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.RatePeriod
			{
				RatePeriodHashKey = source.RatePeriodHashKey.ToCharArray(),
				RatePeriodSqn = source.RatePeriodSqn,
				RatePeriodName = source.RatePeriodName,
				RatePeriodStartDate = source.RatePeriodStartDate.ToDateTime(),
				RatePeriodEndDate = source.RatePeriodEndDate.ToDateTime()
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.SellableInventory ToEntity(this SellableInventory source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.SellableInventory
			{
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				SellableInventorySqn = source.SellableInventorySqn,
				StationHashKey = source.StationHashKey.ToCharArray(),
				StationGroupHashKey = source.StationGroupHashKey.ToCharArray(),
				RateCardHashKey = source.RateCardHashKey.ToCharArray(),
				RateCardDaypartHashKey = source.RateCardDaypartHashKey.ToCharArray(),
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToCharArray(),
				SellingTitleHashKey = source.SellingTitleHashKey.ToCharArray(),
				SellingTitleDaysOfWeekHashKey = source.SellingTitleDaysOfWeekHashKey.ToCharArray(),
				SellingTitleTimeRangeHashKey = source.SellingTitleTimeRangeHashKey.ToCharArray(),
				RatePeriodHashKey = source.RatePeriodHashKey.ToCharArray()
			};

		}
		public  static Videa.InventoryGuideNS.Data.DataServices.SellableInventoryDto ToEntity(this SellableInventoryDto source)
		{
			return new Videa.InventoryGuideNS.Data.DataServices.SellableInventoryDto
			{
				
			};

		}
		#endregion Methods
	}
}
