using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.TrafficStatisticNS.Data.DataServices;
namespace Videa.TrafficStatisticNS.Data.DataServices
{
	public interface ITrafficStatisticDataService
	{
		//methods go here
		Task<bool> RatePeriodDelete(System.String rateperiodhashkey);
		Task<bool> SellableInventoryTrafficStatisticsDelete(System.String sellableinventorytrafficstatistichashkey);
		Task<bool> RatePeriodAddUpdate(RatePeriod rateperiod);
		Task<bool> SellableInventoryTrafficStatisticsAddUpdate(SellableInventoryTrafficStatistics sellableinventorytrafficstatistics);
		Task<IList<TrafficStatistic>> GetTrafficStatistics(object sellableinventorylist);
	}
}
