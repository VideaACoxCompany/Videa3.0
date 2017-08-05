using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.SellableInventoryMartNS.Data.DataServices;
namespace Videa.SellableInventoryMartNS.Data.DataServices
{
	public interface ISellableInventoryMartDataService
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
		Task<bool> SellableInventoryPeriodDelete(System.String sellableinventoryperiodhashkey);
		Task<bool> SellableInventoryDelete(System.String sellableinventoryhashkey);
		Task<bool> SellingTitleAddUpdate(SellingTitle sellingtitle);
		Task<bool> StationAddUpdate(Station station);
		Task<bool> StationGroupAddUpdate(StationGroup stationgroup);
		Task<bool> RateCardAddUpdate(RateCard ratecard);
		Task<bool> RateCardDaypartAddUpdate(RateCardDaypart ratecarddaypart);
		Task<bool> RateCardTypeAddUpdate(RateCardType ratecardtype);
		Task<bool> SellingTitleTimeRangeAddUpdate(SellingTitleTimeRange sellingtitletimerange);
		Task<bool> SellingTitleDaysOfWeekAddUpdate(SellingTitleDaysOfWeek sellingtitledaysofweek);
		Task<bool> SellableInventoryPeriodAddUpdate(SellableInventoryPeriod sellableinventoryperiod);
		Task<bool> SellableInventoryAddUpdate(SellableInventory sellableinventory);
		Task<IList<RateCard>> GetRateCardsByStation(System.String stationhashkey);
		Task<IList<RateCard>> GetRateCardsByDateRange(System.DateTime startdate, System.DateTime enddate);
		Task<IList<SellableInventoryDto>> GetConfirmedInventory(object stationlist, System.String ratecardtypehashkey, object ratecarddaypartlist, object sellingtitlelist, object broadcastweeklist);
	}
}
