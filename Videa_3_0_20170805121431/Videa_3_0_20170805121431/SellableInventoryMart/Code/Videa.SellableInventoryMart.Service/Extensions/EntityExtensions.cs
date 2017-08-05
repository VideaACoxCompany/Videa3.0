using System;
using System.Collections.Generic;
using Videa.SellableInventoryMartNS.Service.Proto.Types;

namespace Videa.SellableInventoryMartNS.Service
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
		public  static SellingTitle ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.SellingTitle source)
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
		public  static Station ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.Station source)
		{
			return new Station
			{
				StationHashKey = source.StationHashKey.ToString(),
				StationSqn = source.StationSqn,
				StationName = source.StationName,
				StationCallLetters = source.StationCallLetters
			};

		}
		public  static StationGroup ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.StationGroup source)
		{
			return new StationGroup
			{
				StationGroupHashKey = source.StationGroupHashKey.ToString(),
				StationGroupSqn = source.StationGroupSqn,
				StationGroupName = source.StationGroupName
			};

		}
		public  static RateCard ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.RateCard source)
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
		public  static RateCardDaypart ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.RateCardDaypart source)
		{
			return new RateCardDaypart
			{
				RateCardDaypartHashKey = source.RateCardDaypartHashKey.ToString(),
				RateCardDaypartSqn = source.RateCardDaypartSqn,
				RateCardDaypartName = source.RateCardDaypartName
			};

		}
		public  static RateCardType ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.RateCardType source)
		{
			return new RateCardType
			{
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToString(),
				RateCardTypeSqn = source.RateCardTypeSqn,
				RateCardTypeName = source.RateCardTypeName
			};

		}
		public  static SellingTitleTimeRange ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleTimeRange source)
		{
			return new SellingTitleTimeRange
			{
				SellingTitleTimeRangeHashKey = source.SellingTitleTimeRangeHashKey.ToString(),
				TimeRangeSqn = source.TimeRangeSqn,
				SellingTitleTimeRangeName = source.SellingTitleTimeRangeName
			};

		}
		public  static SellingTitleDaysOfWeek ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleDaysOfWeek source)
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
		public  static SellableInventoryPeriod ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryPeriod source)
		{
			return new SellableInventoryPeriod
			{
				SellableInventoryPeriodHashKey = source.SellableInventoryPeriodHashKey.ToString(),
				SellableInventoryPeriodSqn = source.SellableInventoryPeriodSqn,
				SellableInventoryPeriodName = source.SellableInventoryPeriodName,
				SellableInventoryPeriodStartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellableInventoryPeriodStartDate),
				SellableInventoryPeriodEndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellableInventoryPeriodEndDate)
			};

		}
		public  static SellableInventory ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.SellableInventory source)
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
				SellableInventoryPeriodHashKey = source.SellableInventoryPeriodHashKey.ToString()
			};

		}
		public  static SellableInventoryDto ToProto(this Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryDto source)
		{
			return new SellableInventoryDto
			{
				SellingTitleStartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellingTitleStartDate),
				SellingTitleEndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.SellingTitleEndDate),
				SellingTitleName = source.SellingTitleName,
				RateCardDaypartName = source.RateCardDaypartName,
				SellingTitleDaysOfWeekName = source.SellingTitleDaysOfWeekName,
				RateCardTypeName = source.RateCardTypeName,
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				StationHashKey = source.StationHashKey.ToString(),
				SellingTitleDaysOfWeekHashKey = source.SellingTitleDaysOfWeekHashKey.ToString(),
				RateCardTypeHashKey = source.RateCardTypeHashKey.ToString()
			};

		}
		#endregion Methods
	}
}
