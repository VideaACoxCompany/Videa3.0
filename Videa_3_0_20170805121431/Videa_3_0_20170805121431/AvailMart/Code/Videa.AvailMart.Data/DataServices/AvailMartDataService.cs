using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Data.DataServices
{
	public class AvailMartDataService : BaseDataService, IAvailMartDataService
	{
		#region Fields
		private    int DefaultPageNumber;
		private    int DefaultPageSize;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailMartDataService(IAvailMartDbProvider dbProvider) : base(dbProvider)
		{
			//empty constructor
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> AvailMartDelete(System.String availmarthashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@AvailMartHashKey",availmarthashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.AvailMartDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> AvailListDelete(System.String availlisthashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@AvailListHashKey",availlisthashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.AvailListDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> AvailLineWithDetailedPeriodsDelete(System.String availlinewithdetailedperiodshashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@AvailLineWithDetailedPeriodsHashKey",availlinewithdetailedperiodshashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.AvailLineWithDetailedPeriodsDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> DetailedPeriodDelete(System.String detailedperiodhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@DetailedPeriodHashKey",detailedperiodhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.DetailedPeriodDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> AvailMartAddUpdate(AvailMart availmart)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@AvailMartHashKey",availmart.AvailMartHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@AvailMartSqn",availmart.AvailMartSqn, DbType.Int32);
				sqlParams.Add("@StartDate",availmart.StartDate, DbType.DateTime);
				sqlParams.Add("@EndDate",availmart.EndDate, DbType.DateTime);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.AvailMartAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> AvailListAddUpdate(AvailList availlist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@AvailListHashKey",availlist.AvailListHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@AvailListSqn",availlist.AvailListSqn, DbType.Int32);
				sqlParams.Add("@AvailMartHashKey",availlist.AvailMartHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@Name",availlist.Name, DbType.AnsiString);
				sqlParams.Add("@StartDate",availlist.StartDate, DbType.DateTime);
				sqlParams.Add("@EndDate",availlist.EndDate, DbType.DateTime);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.AvailListAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> AvailLineWithDetailedPeriodsAddUpdate(AvailLineWithDetailedPeriods availlinewithdetailedperiods)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@AvailLineWithDetailedPeriodsHashKey",availlinewithdetailedperiods.AvailLineWithDetailedPeriodsHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@AvailLineWithDetailedPeriodsSqn",availlinewithdetailedperiods.AvailLineWithDetailedPeriodsSqn, DbType.Int32);
				sqlParams.Add("@AvailListHashKey",availlinewithdetailedperiods.AvailListHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@DaypartName",availlinewithdetailedperiods.DaypartName, DbType.AnsiString);
				sqlParams.Add("@AvailName",availlinewithdetailedperiods.AvailName, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.AvailLineWithDetailedPeriodsAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> DetailedPeriodAddUpdate(DetailedPeriod detailedperiod)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@DetailedPeriodHashKey",detailedperiod.DetailedPeriodHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@DetailedPeriodSqn",detailedperiod.DetailedPeriodSqn, DbType.Int32);
				sqlParams.Add("@AvailLineWithDetailedPeriodsHashKey",detailedperiod.AvailLineWithDetailedPeriodsHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@StartDate",detailedperiod.StartDate, DbType.DateTime);
				sqlParams.Add("@EndDate",detailedperiod.EndDate, DbType.DateTime);
				sqlParams.Add("@Rate",detailedperiod.Rate, DbType.Decimal);
				
				var result = await connection
				     .ExecuteAsync(
				     "AMApi.DetailedPeriodAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<IList<AvailMart>> GetAvailMart(System.String stationhashkey, System.String ratecardtypehashkey, System.String dayparthashkey, object broadcastweeklist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StationHashKey",stationhashkey, DbType.String);
				sqlParams.Add("@RateCardTypeHashKey",ratecardtypehashkey, DbType.String);
				sqlParams.Add("@DaypartHashKey",dayparthashkey, DbType.String);
				sqlParams.Add("@BroadcastWeekList",broadcastweeklist, DbType.String);
				
				var result = await connection
				     .QueryAsync<AvailMart>(
				     "AvailMartApi.GetAvailMart",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		#endregion Methods
	}
}
