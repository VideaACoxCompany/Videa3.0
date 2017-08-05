using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.SellerRateNS.Data.DataServices;
namespace Videa.SellerRateNS.Data.DataServices
{
	public interface ISellerRateDataService
	{
		//methods go here
		Task<bool> RateTierDelete(System.String ratetierhashkey);
		Task<bool> RatePeriodDelete(System.String rateperiodhashkey);
		Task<bool> SellableInventoryRateDelete(System.String sellableinventoryratehashkey);
		Task<bool> RateTierAddUpdate(RateTier ratetier);
		Task<bool> RatePeriodAddUpdate(RatePeriod rateperiod);
		Task<bool> SellableInventoryRateAddUpdate(SellableInventoryRate sellableinventoryrate);
		Task<IList<Rate>> GetSellerRatesByInventoryKeys(object sellableinventorylist);
		Task<IList<Rate>> GetSellerRatesByRateKeys(object sellableinventoryratelist);
	}
}
