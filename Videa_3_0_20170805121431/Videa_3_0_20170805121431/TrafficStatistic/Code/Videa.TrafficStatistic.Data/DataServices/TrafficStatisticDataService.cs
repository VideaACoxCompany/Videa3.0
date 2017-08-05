using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Data.DataServices
{
	public class TrafficStatisticDataService : BaseDataService, ITrafficStatisticDataService
	{
		#region Fields
		private    int DefaultPageNumber;
		private    int DefaultPageSize;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public TrafficStatisticDataService(ITrafficStatisticDbProvider dbProvider) : base(dbProvider)
		{
			//empty constructor
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> RatePeriodDelete(System.String rateperiodhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatePeriodHashKey",rateperiodhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "TrafficStatisticApi.RatePeriodDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryTrafficStatisticsDelete(System.String sellableinventorytrafficstatistichashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryTrafficStatisticHashKey",sellableinventorytrafficstatistichashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "TrafficStatisticApi.SellableInventoryTrafficStatisticsDelete",
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
				     "TrafficStatisticApi.RatePeriodAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryTrafficStatisticsAddUpdate(SellableInventoryTrafficStatistics sellableinventorytrafficstatistics)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryTrafficStatisticHashKey",sellableinventorytrafficstatistics.SellableInventoryTrafficStatisticHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryHashKey",sellableinventorytrafficstatistics.SellableInventoryHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryTrafficStatisticSqn",sellableinventorytrafficstatistics.SellableInventoryTrafficStatisticSqn, DbType.Int32);
				sqlParams.Add("@SellableInventoryAURValue",sellableinventorytrafficstatistics.SellableInventoryAURValue, DbType.Decimal);
				sqlParams.Add("@RowVersion",sellableinventorytrafficstatistics.RowVersion, DbType.Binary);
				
				var result = await connection
				     .ExecuteAsync(
				     "TrafficStatisticApi.SellableInventoryTrafficStatisticsAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<IList<TrafficStatistic>> GetTrafficStatistics(object sellableinventorylist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryList",sellableinventorylist, DbType.String);
				
				var result = await connection
				     .QueryAsync<TrafficStatistic>(
				     "TrafficStatistic.GetTrafficStatistics",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		#endregion Methods
	}
}
