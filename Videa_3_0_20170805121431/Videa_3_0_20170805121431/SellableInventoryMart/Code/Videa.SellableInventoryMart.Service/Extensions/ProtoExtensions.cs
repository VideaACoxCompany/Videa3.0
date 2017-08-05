using System;
using System.Collections.Generic;
using Videa.SellableInventoryMartNS.Service.Proto.Types;

namespace Videa.SellableInventoryMartNS.Service
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
		public  static Videa.SellableInventoryMartNS.Data.DataServices.SellingTitle ToEntity(this SellingTitle source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.SellingTitle
			{
				SellingTitleHashKey = source.SellingTitleHashKey.ToCharArray(),
				SellingTitleSqn = source.SellingTitleSqn,
				SellingTitleName = source.SellingTitleName,
				SellingTitleStartDate = source.SellingTitleStartDate.ToDateTime(),
				SellingTitleEndDate = source.SellingTitleEndDate.ToDateTime()
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.Station ToEntity(this Station source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.Station
			{
				StationHashKey = source.StationHashKey.ToCharArray(),
				StationSqn = source.StationSqn,
				StationName = source.StationName,
				StationCallLetters = source.StationCallLetters
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.StationGroup ToEntity(this StationGroup source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.StationGroup
			{
				StationGroupHashKey = source.StationGroupHashKey.ToCharArray(),
				StationGroupSqn = source.StationGroupSqn,
				StationGroupName = source.StationGroupName
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.RateCard ToEntity(this RateCard source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.RateCard
			{
				RateCardHashKey = source.RateCardHashKey.ToCharArray(),
				RateCardSqn = source.RateCardSqn,
				RateCardName = source.RateCardName,
				RateCardStartDate = source.RateCardStartDate.ToDateTime(),
				RateCardEndDate = source.RateCardEndDate.ToDateTime()
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.RateCardDaypart ToEntity(this RateCardDaypart source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.RateCardDaypart
			{
				RateCardDaypartHashKey = source.RateCardDaypartHashKey.ToCharArray(),
				RateCardDaypartSqn = source.RateCardDaypartSqn,
				RateCardDaypartName = source.RateCardDaypartName
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.RateCardType ToEntity(this RateCardType source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.RateCardType
			{
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToCharArray(),
				RateCardTypeSqn = source.RateCardTypeSqn,
				RateCardTypeName = source.RateCardTypeName
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleTimeRange ToEntity(this SellingTitleTimeRange source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleTimeRange
			{
				SellingTitleTimeRangeHashKey = source.SellingTitleTimeRangeHashKey.ToCharArray(),
				TimeRangeSqn = source.TimeRangeSqn,
				SellingTitleTimeRangeName = source.SellingTitleTimeRangeName
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleDaysOfWeek ToEntity(this SellingTitleDaysOfWeek source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleDaysOfWeek
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
		public  static Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryPeriod ToEntity(this SellableInventoryPeriod source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryPeriod
			{
				SellableInventoryPeriodHashKey = source.SellableInventoryPeriodHashKey.ToCharArray(),
				SellableInventoryPeriodSqn = source.SellableInventoryPeriodSqn,
				SellableInventoryPeriodName = source.SellableInventoryPeriodName,
				SellableInventoryPeriodStartDate = source.SellableInventoryPeriodStartDate.ToDateTime(),
				SellableInventoryPeriodEndDate = source.SellableInventoryPeriodEndDate.ToDateTime()
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.SellableInventory ToEntity(this SellableInventory source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.SellableInventory
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
				SellableInventoryPeriodHashKey = source.SellableInventoryPeriodHashKey.ToCharArray()
			};

		}
		public  static Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryDto ToEntity(this SellableInventoryDto source)
		{
			return new Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryDto
			{
				SellingTitleStartDate = source.SellingTitleStartDate.ToDateTime(),
				SellingTitleEndDate = source.SellingTitleEndDate.ToDateTime(),
				SellingTitleName = source.SellingTitleName,
				RateCardDaypartName = source.RateCardDaypartName,
				SellingTitleDaysOfWeekName = source.SellingTitleDaysOfWeekName,
				RateCardTypeName = source.RateCardTypeName,
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				StationHashKey = source.StationHashKey.ToCharArray(),
				SellingTitleDaysOfWeekHashKey = source.SellingTitleDaysOfWeekHashKey.ToCharArray(),
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToCharArray()
			};

		}
		#endregion Methods
	}
}
