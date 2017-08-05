using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.SharebuilderRateNS.Data.DataServices;
namespace Videa.SharebuilderRateNS.Data.DataServices
{
	public interface ISharebuilderRateDataService
	{
		//methods go here
		Task<bool> RateTierDelete(System.String ratetierhashkey);
		Task<bool> RatePeriodDelete(System.String rateperiodhashkey);
		Task<bool> SellableInventoryRateDelete(System.String sellableinventoryratehashkey);
		Task<bool> RateTierAddUpdate(RateTier ratetier);
		Task<bool> RatePeriodAddUpdate(RatePeriod rateperiod);
		Task<bool> SellableInventoryRateAddUpdate(SellableInventoryRate sellableinventoryrate);
		Task<IList<Rate>> GetSharebuilderRates(object sellableinventorylist);
	}
}
