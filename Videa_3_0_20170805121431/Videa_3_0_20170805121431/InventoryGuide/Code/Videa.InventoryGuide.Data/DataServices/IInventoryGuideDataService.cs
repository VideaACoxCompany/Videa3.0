using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.InventoryGuideNS.Data.DataServices;
namespace Videa.InventoryGuideNS.Data.DataServices
{
	public interface IInventoryGuideDataService
	{
		//methods go here
		Task<bool> SellingTitleDelete(System.String sellingtitlehashkey);
		Task<bool> StationDelete(System.String stationhashkey);
		Task<bool> StationGroupDelete(System.String stationgrouphashkey);
		Task<bool> RateCardDelete(System.String ratecardhashkey);
		Task<bool> RateCardDaypartDelete(System.String ratecarddayparthashkey);
		Task<bool> RateCardTypeDelete(System.String ratecardtypehashkey);
		Task<bool> SellingTitleTimeRangeDelete(System.String sellingtitletimerangehashkey);
		Task<bool> SellingTitleDaysOfWeekDelete(System.String sellingtitledaysofweekhashkey);
		Task<bool> RatePeriodDelete(System.String rateperiodhashkey);
		Task<bool> SellableInventoryDelete(System.String sellableinventoryhashkey);
		Task<bool> SellingTitleAddUpdate(SellingTitle sellingtitle);
		Task<bool> StationAddUpdate(Station station);
		Task<bool> StationGroupAddUpdate(StationGroup stationgroup);
		Task<bool> RateCardAddUpdate(RateCard ratecard);
		Task<bool> RateCardDaypartAddUpdate(RateCardDaypart ratecarddaypart);
		Task<bool> RateCardTypeAddUpdate(RateCardType ratecardtype);
		Task<bool> SellingTitleTimeRangeAddUpdate(SellingTitleTimeRange sellingtitletimerange);
		Task<bool> SellingTitleDaysOfWeekAddUpdate(SellingTitleDaysOfWeek sellingtitledaysofweek);
		Task<bool> RatePeriodAddUpdate(RatePeriod rateperiod);
		Task<bool> SellableInventoryAddUpdate(SellableInventory sellableinventory);
		Task<bool> GetRateCardsByStation(System.String stationhashkey);
		Task<bool> GetRateCardsByDateRange(System.DateTime startdate, System.DateTime enddate);
		Task<bool> GetUnconfirmedInventory(System.String stationhashkey, System.String ratecardtypehashkey, System.String ratecarddayparthashkey, object broadcastweeklist);
	}
}
