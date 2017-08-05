using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Data.DataServices
{
	public class SharebuilderRateDataService : BaseDataService, ISharebuilderRateDataService
	{
		#region Fields
		private    int DefaultPageNumber;
		private    int DefaultPageSize;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SharebuilderRateDataService(ISharebuilderRateDbProvider dbProvider) : base(dbProvider)
		{
			//empty constructor
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> RateTierDelete(System.String ratetierhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateTierHashKey",ratetierhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SharebuilderRateApi.RateTierDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RatePeriodDelete(System.String rateperiodhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatePeriodHashKey",rateperiodhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SharebuilderRateApi.RatePeriodDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryRateDelete(System.String sellableinventoryratehashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryRateHashKey",sellableinventoryratehashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SharebuilderRateApi.SellableInventoryRateDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateTierAddUpdate(RateTier ratetier)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateTierHashKey",ratetier.RateTierHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateTierSqn",ratetier.RateTierSqn, DbType.Int32);
				sqlParams.Add("@RateTierName",ratetier.RateTierName, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SharebuilderRateApi.RateTierAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RatePeriodAddUpdate(RatePeriod rateperiod)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatePeriodHashKey",rateperiod.RatePeriodHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RatePeriodSqn",rateperiod.RatePeriodSqn, DbType.Int32);
				sqlParams.Add("@RatePeriodName",rateperiod.RatePeriodName, DbType.AnsiString);
				sqlParams.Add("@RatePeriodStartDate",rateperiod.RatePeriodStartDate, DbType.DateTime);
				sqlParams.Add("@RatePeriodEndDate",rateperiod.RatePeriodEndDate, DbType.DateTime);
				
				var result = await connection
				     .ExecuteAsync(
				     "SharebuilderRateApi.RatePeriodAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryRateAddUpdate(SellableInventoryRate sellableinventoryrate)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryRateHashKey",sellableinventoryrate.SellableInventoryRateHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryHashKey",sellableinventoryrate.SellableInventoryHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryRateSqn",sellableinventoryrate.SellableInventoryRateSqn, DbType.Int32);
				sqlParams.Add("@RateTierHashKey",sellableinventoryrate.RateTierHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryRateValue",sellableinventoryrate.SellableInventoryRateValue, DbType.Decimal);
				sqlParams.Add("@RowVersion",sellableinventoryrate.RowVersion, DbType.Binary);
				
				var result = await connection
				     .ExecuteAsync(
				     "SharebuilderRateApi.SellableInventoryRateAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<IList<Rate>> GetSharebuilderRates(object sellableinventorylist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryList",sellableinventorylist, DbType.String);
				
				var result = await connection
				     .QueryAsync<Rate>(
				     "SharebuilderRateApi.GetSharebuilderRates",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		#endregion Methods
	}
}
