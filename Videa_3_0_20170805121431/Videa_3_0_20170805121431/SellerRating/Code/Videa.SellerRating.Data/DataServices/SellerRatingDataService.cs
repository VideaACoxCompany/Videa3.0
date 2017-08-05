using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Data.DataServices
{
	public class SellerRatingDataService : BaseDataService, ISellerRatingDataService
	{
		#region Fields
		private    int DefaultPageNumber;
		private    int DefaultPageSize;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellerRatingDataService(ISellerRatingDbProvider dbProvider) : base(dbProvider)
		{
			//empty constructor
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> RatingDemoDelete(System.String ratingdemohashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatingDemoHashKey",ratingdemohashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SellerRatingApi.RatingDemoDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RatingPeriodDelete(System.String ratingperiodhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatingPeriodHashKey",ratingperiodhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SellerRatingApi.RatingPeriodDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryRatingDelete(System.String sellableinventoryratinghashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryRatingHashKey",sellableinventoryratinghashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SellerRatingApi.SellableInventoryRatingDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RatingDemoAddUpdate(RatingDemo ratingdemo)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatingDemoHashKey",ratingdemo.RatingDemoHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RatingDemoSqn",ratingdemo.RatingDemoSqn, DbType.Int32);
				sqlParams.Add("@RatingDemoName",ratingdemo.RatingDemoName, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SellerRatingApi.RatingDemoAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RatingPeriodAddUpdate(RatingPeriod ratingperiod)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatingPeriodHashKey",ratingperiod.RatingPeriodHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RatingPeriodSqn",ratingperiod.RatingPeriodSqn, DbType.Int32);
				sqlParams.Add("@RatingPeriodName",ratingperiod.RatingPeriodName, DbType.AnsiString);
				sqlParams.Add("@RatingPeriodStartDate",ratingperiod.RatingPeriodStartDate, DbType.DateTime);
				sqlParams.Add("@RatingPeriodEndDate",ratingperiod.RatingPeriodEndDate, DbType.DateTime);
				
				var result = await connection
				     .ExecuteAsync(
				     "SellerRatingApi.RatingPeriodAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryRatingAddUpdate(SellableInventoryRating sellableinventoryrating)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryRatingHashKey",sellableinventoryrating.SellableInventoryRatingHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryHashKey",sellableinventoryrating.SellableInventoryHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryRatingSqn",sellableinventoryrating.SellableInventoryRatingSqn, DbType.Int32);
				sqlParams.Add("@RatingDemoHashKey",sellableinventoryrating.RatingDemoHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RatingPeriodHashKey",sellableinventoryrating.RatingPeriodHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryRatingValue",sellableinventoryrating.SellableInventoryRatingValue, DbType.Decimal);
				sqlParams.Add("@RowVersion",sellableinventoryrating.RowVersion, DbType.Binary);
				
				var result = await connection
				     .ExecuteAsync(
				     "SellerRatingApi.SellableInventoryRatingAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<IList<Rating>> GetSellerRatingsByInventoryKeys(object sellableinventorylist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryList",sellableinventorylist, DbType.String);
				
				var result = await connection
				     .QueryAsync<Rating>(
				     "SellerRating.GetSellerRatingsByInventoryKeys",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		public  async Task<IList<Rating>> GetSellerRatingsByRatingKeys(object sellableinventoryratinglist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryRatingList",sellableinventoryratinglist, DbType.String);
				
				var result = await connection
				     .QueryAsync<Rating>(
				     "SellerRating.GetSellerRatingsByRatingKeys",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		#endregion Methods
	}
}
