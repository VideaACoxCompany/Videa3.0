using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.SellerRatingNS.Data.DataServices;
namespace Videa.SellerRatingNS.Data.DataServices
{
	public interface ISellerRatingDataService
	{
		//methods go here
		Task<bool> RatingDemoDelete(System.String ratingdemohashkey);
		Task<bool> RatingPeriodDelete(System.String ratingperiodhashkey);
		Task<bool> SellableInventoryRatingDelete(System.String sellableinventoryratinghashkey);
		Task<bool> RatingDemoAddUpdate(RatingDemo ratingdemo);
		Task<bool> RatingPeriodAddUpdate(RatingPeriod ratingperiod);
		Task<bool> SellableInventoryRatingAddUpdate(SellableInventoryRating sellableinventoryrating);
		Task<IList<Rating>> GetSellerRatingsByInventoryKeys(object sellableinventorylist);
		Task<IList<Rating>> GetSellerRatingsByRatingKeys(object sellableinventoryratinglist);
	}
}
