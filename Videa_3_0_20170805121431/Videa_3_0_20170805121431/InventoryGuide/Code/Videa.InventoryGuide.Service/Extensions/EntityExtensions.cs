using System;
using System.Collections.Generic;
using Videa.InventoryGuideNS.Service.Proto.Types;

namespace Videa.InventoryGuideNS.Service
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
		public  static SellingTitle ToProto(this Videa.InventoryGuideNS.Data.DataServices.SellingTitle source)
		{
			return new SellingTitle
			{
				SellingTitleHashKey = source.SellingTitleHashKey.ToString(),
				SellingTitleSqn = source.SellingTitleSqn,
				SellingTitleName = source.SellingTitleName,
				SellingTitleStartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellingTitleStartDate),
				SellingTitleEndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellingTitleEndDate)
			};

		}
		public  static Station ToProto(this Videa.InventoryGuideNS.Data.DataServices.Station source)
		{
			return new Station
			{
				StationHashKey = source.StationHashKey.ToString(),
				StationSqn = source.StationSqn,
				StationName = source.StationName,
				StationCallLetters = source.StationCallLetters
			};

		}
		public  static StationGroup ToProto(this Videa.InventoryGuideNS.Data.DataServices.StationGroup source)
		{
			return new StationGroup
			{
				StationGroupHashKey = source.StationGroupHashKey.ToString(),
				StationGroupSqn = source.StationGroupSqn,
				StationGroupName = source.StationGroupName
			};

		}
		public  static RateCard ToProto(this Videa.InventoryGuideNS.Data.DataServices.RateCard source)
		{
			return new RateCard
			{
				RateCardHashKey = source.RateCardHashKey.ToString(),
				RateCardSqn = source.RateCardSqn,
				RateCardName = source.RateCardName,
				RateCardStartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.RateCardStartDate),
				RateCardEndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.RateCardEndDate)
			};

		}
		public  static RateCardDaypart ToProto(this Videa.InventoryGuideNS.Data.DataServices.RateCardDaypart source)
		{
			return new RateCardDaypart
			{
				RateCardDaypartHashKey = source.RateCardDaypartHashKey.ToString(),
				RateCardDaypartSqn = source.RateCardDaypartSqn,
				RateCardDaypartName = source.RateCardDaypartName
			};

		}
		public  static RateCardType ToProto(this Videa.InventoryGuideNS.Data.DataServices.RateCardType source)
		{
			return new RateCardType
			{
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToString(),
				RateCardTypeSqn = source.RateCardTypeSqn,
				RateCardTypeName = source.RateCardTypeName
			};

		}
		public  static SellingTitleTimeRange ToProto(this Videa.InventoryGuideNS.Data.DataServices.SellingTitleTimeRange source)
		{
			return new SellingTitleTimeRange
			{
				SellingTitleTimeRangeHashKey = source.SellingTitleTimeRangeHashKey.ToString(),
				TimeRangeSqn = source.TimeRangeSqn,
				SellingTitleTimeRangeName = source.SellingTitleTimeRangeName
			};

		}
		public  static SellingTitleDaysOfWeek ToProto(this Videa.InventoryGuideNS.Data.DataServices.SellingTitleDaysOfWeek source)
		{
			return new SellingTitleDaysOfWeek
			{
				SellingTitleDaysOfWeekHashKey = source.SellingTitleDaysOfWeekHashKey.ToString(),
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
		public  static RatePeriod ToProto(this Videa.InventoryGuideNS.Data.DataServices.RatePeriod source)
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
		public  static SellableInventory ToProto(this Videa.InventoryGuideNS.Data.DataServices.SellableInventory source)
		{
			return new SellableInventory
			{
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				SellableInventorySqn = source.SellableInventorySqn,
				StationHashKey = source.StationHashKey.ToString(),
				StationGroupHashKey = source.StationGroupHashKey.ToString(),
				RateCardHashKey = source.RateCardHashKey.ToString(),
				RateCardDaypartHashKey = source.RateCardDaypartHashKey.ToString(),
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToString(),
				SellingTitleHashKey = source.SellingTitleHashKey.ToString(),
				SellingTitleDaysOfWeekHashKey = source.SellingTitleDaysOfWeekHashKey.ToString(),
				SellingTitleTimeRangeHashKey = source.SellingTitleTimeRangeHashKey.ToString(),
				RatePeriodHashKey = source.RatePeriodHashKey.ToString()
			};

		}
		public  static SellableInventoryDto ToProto(this Videa.InventoryGuideNS.Data.DataServices.SellableInventoryDto source)
		{
			return new SellableInventoryDto
			{
				
			};

		}
		#endregion Methods
	}
}
