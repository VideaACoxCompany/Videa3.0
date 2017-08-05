using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Data.DataServices
{
	public class SellableInventoryMartDataService : BaseDataService, ISellableInventoryMartDataService
	{
		#region Fields
		private    int DefaultPageNumber;
		private    int DefaultPageSize;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryMartDataService(ISellableInventoryMartDbProvider dbProvider) : base(dbProvider)
		{
			//empty constructor
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> SellingTitleDelete(System.String sellingtitlehashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellingTitleHashKey",sellingtitlehashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellingTitleDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> StationDelete(System.String stationhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StationHashKey",stationhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.StationDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> StationGroupDelete(System.String stationgrouphashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StationGroupHashKey",stationgrouphashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.StationGroupDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateCardDelete(System.String ratecardhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateCardHashKey",ratecardhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.RateCardDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateCardDaypartDelete(System.String ratecarddayparthashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateCardDaypartHashKey",ratecarddayparthashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.RateCardDaypartDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateCardTypeDelete(System.String ratecardtypehashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateCardTypeHashKey",ratecardtypehashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.RateCardTypeDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellingTitleTimeRangeDelete(System.String sellingtitletimerangehashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellingTitleTimeRangeHashKey",sellingtitletimerangehashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellingTitleTimeRangeDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellingTitleDaysOfWeekDelete(System.String sellingtitledaysofweekhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellingTitleDaysOfWeekHashKey",sellingtitledaysofweekhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellingTitleDaysOfWeekDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryPeriodDelete(System.String sellableinventoryperiodhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryPeriodHashKey",sellableinventoryperiodhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellableInventoryPeriodDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryDelete(System.String sellableinventoryhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryHashKey",sellableinventoryhashkey, DbType.StringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellableInventoryDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellingTitleAddUpdate(SellingTitle sellingtitle)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellingTitleHashKey",sellingtitle.SellingTitleHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellingTitleSqn",sellingtitle.SellingTitleSqn, DbType.Int32);
				sqlParams.Add("@SellingTitleName",sellingtitle.SellingTitleName, DbType.AnsiString);
				sqlParams.Add("@SellingTitleStartDate",sellingtitle.SellingTitleStartDate, DbType.DateTime);
				sqlParams.Add("@SellingTitleEndDate",sellingtitle.SellingTitleEndDate, DbType.DateTime);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellingTitleAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> StationAddUpdate(Station station)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StationHashKey",station.StationHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@StationSqn",station.StationSqn, DbType.Int32);
				sqlParams.Add("@StationName",station.StationName, DbType.AnsiString);
				sqlParams.Add("@StationCallLetters",station.StationCallLetters, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.StationAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> StationGroupAddUpdate(StationGroup stationgroup)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StationGroupHashKey",stationgroup.StationGroupHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@StationGroupSqn",stationgroup.StationGroupSqn, DbType.Int32);
				sqlParams.Add("@StationGroupName",stationgroup.StationGroupName, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.StationGroupAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateCardAddUpdate(RateCard ratecard)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateCardHashKey",ratecard.RateCardHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateCardSqn",ratecard.RateCardSqn, DbType.Int32);
				sqlParams.Add("@RateCardName",ratecard.RateCardName, DbType.AnsiString);
				sqlParams.Add("@RateCardStartDate",ratecard.RateCardStartDate, DbType.DateTime);
				sqlParams.Add("@RateCardEndDate",ratecard.RateCardEndDate, DbType.DateTime);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.RateCardAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateCardDaypartAddUpdate(RateCardDaypart ratecarddaypart)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateCardDaypartHashKey",ratecarddaypart.RateCardDaypartHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateCardDaypartSqn",ratecarddaypart.RateCardDaypartSqn, DbType.Int32);
				sqlParams.Add("@RateCardDaypartName",ratecarddaypart.RateCardDaypartName, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.RateCardDaypartAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateCardTypeAddUpdate(RateCardType ratecardtype)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateCardTypeHashKey",ratecardtype.RateCardTypeHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateCardTypeSqn",ratecardtype.RateCardTypeSqn, DbType.Int32);
				sqlParams.Add("@RateCardTypeName",ratecardtype.RateCardTypeName, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.RateCardTypeAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellingTitleTimeRangeAddUpdate(SellingTitleTimeRange sellingtitletimerange)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellingTitleTimeRangeHashKey",sellingtitletimerange.SellingTitleTimeRangeHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@TimeRangeSqn",sellingtitletimerange.TimeRangeSqn, DbType.Int32);
				sqlParams.Add("@SellingTitleTimeRangeName",sellingtitletimerange.SellingTitleTimeRangeName, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellingTitleTimeRangeAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellingTitleDaysOfWeekAddUpdate(SellingTitleDaysOfWeek sellingtitledaysofweek)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellingTitleDaysOfWeekHashKey",sellingtitledaysofweek.SellingTitleDaysOfWeekHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellingTitleDaysOfWeekSqn",sellingtitledaysofweek.SellingTitleDaysOfWeekSqn, DbType.Int32);
				sqlParams.Add("@SellingTitleDaysOfWeekName",sellingtitledaysofweek.SellingTitleDaysOfWeekName, DbType.AnsiString);
				sqlParams.Add("@Mon",sellingtitledaysofweek.Mon, DbType.Boolean);
				sqlParams.Add("@Tue",sellingtitledaysofweek.Tue, DbType.Boolean);
				sqlParams.Add("@Wed",sellingtitledaysofweek.Wed, DbType.Boolean);
				sqlParams.Add("@Thu",sellingtitledaysofweek.Thu, DbType.Boolean);
				sqlParams.Add("@Fri",sellingtitledaysofweek.Fri, DbType.Boolean);
				sqlParams.Add("@Sat",sellingtitledaysofweek.Sat, DbType.Boolean);
				sqlParams.Add("@Sun",sellingtitledaysofweek.Sun, DbType.Boolean);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellingTitleDaysOfWeekAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryPeriodAddUpdate(SellableInventoryPeriod sellableinventoryperiod)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryPeriodHashKey",sellableinventoryperiod.SellableInventoryPeriodHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryPeriodSqn",sellableinventoryperiod.SellableInventoryPeriodSqn, DbType.Int32);
				sqlParams.Add("@SellableInventoryPeriodName",sellableinventoryperiod.SellableInventoryPeriodName, DbType.AnsiString);
				sqlParams.Add("@SellableInventoryPeriodStartDate",sellableinventoryperiod.SellableInventoryPeriodStartDate, DbType.DateTime);
				sqlParams.Add("@SellableInventoryPeriodEndDate",sellableinventoryperiod.SellableInventoryPeriodEndDate, DbType.DateTime);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellableInventoryPeriodAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> SellableInventoryAddUpdate(SellableInventory sellableinventory)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryHashKey",sellableinventory.SellableInventoryHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventorySqn",sellableinventory.SellableInventorySqn, DbType.Int32);
				sqlParams.Add("@StationHashKey",sellableinventory.StationHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@StationGroupHashKey",sellableinventory.StationGroupHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateCardHashKey",sellableinventory.RateCardHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateCardDaypartHashKey",sellableinventory.RateCardDaypartHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateCardTypeHashKey",sellableinventory.RateCardTypeHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellingTitleHashKey",sellableinventory.SellingTitleHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellingTitleDaysOfWeekHashKey",sellableinventory.SellingTitleDaysOfWeekHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellingTitleTimeRangeHashKey",sellableinventory.SellingTitleTimeRangeHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@SellableInventoryPeriodHashKey",sellableinventory.SellableInventoryPeriodHashKey, DbType.AnsiStringFixedLength);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIMApi.SellableInventoryAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<IList<RateCard>> GetRateCardsByStation(System.String stationhashkey)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StationHashKey",stationhashkey, DbType.String);
				
				var result = await connection
				     .QueryAsync<RateCard>(
				     "SIMApi.GetRateCardsByStation",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		public  async Task<IList<RateCard>> GetRateCardsByDateRange(System.DateTime startdate, System.DateTime enddate)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StartDate",startdate, DbType.String);
				sqlParams.Add("@EndDate",enddate, DbType.String);
				
				var result = await connection
				     .QueryAsync<RateCard>(
				     "SIMApi.GetRateCardsByDateRange",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		public  async Task<IList<SellableInventoryDto>> GetConfirmedInventory(object stationlist, System.String ratecardtypehashkey, object ratecarddaypartlist, object sellingtitlelist, object broadcastweeklist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@StationList",stationlist, DbType.String);
				sqlParams.Add("@RateCardTypeHashKey",ratecardtypehashkey, DbType.String);
				sqlParams.Add("@RateCardDaypartList",ratecarddaypartlist, DbType.String);
				sqlParams.Add("@SellingTitleList",sellingtitlelist, DbType.String);
				sqlParams.Add("@BroadcastWeekList",broadcastweeklist, DbType.String);
				
				var result = await connection
				     .QueryAsync<SellableInventoryDto>(
				     "SIMApi.GetConfirmedInventory",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		#endregion Methods
	}
}
