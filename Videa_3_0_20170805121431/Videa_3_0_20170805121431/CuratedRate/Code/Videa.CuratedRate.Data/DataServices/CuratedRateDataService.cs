using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Data.DataServices
{
	public class CuratedRateDataService : BaseDataService, ICuratedRateDataService
	{
		#region Fields
		private    int DefaultPageNumber;
		private    int DefaultPageSize;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRateDataService(ICuratedRateDbProvider dbProvider) : base(dbProvider)
		{
			//empty constructor
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> CuratedRateDelete(System.Int64 curatedrateid)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@CuratedRateId",curatedrateid, DbType.Int64);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRApi.CuratedRateDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateTypeDelete(System.Int32 ratetypeid)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateTypeId",ratetypeid, DbType.Int32);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRApi.RateTypeDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> CurationStatusDelete(System.Int32 curationstatusid)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@CurationStatusId",curationstatusid, DbType.Int32);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRApi.CurationStatusDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> CuratedRateAddUpdate(CuratedRate curatedrate)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@CuratedRateId",curatedrate.CuratedRateId, DbType.Int32);
				sqlParams.Add("@SellableInventoryHashKey",curatedrate.SellableInventoryHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateHashKey",curatedrate.RateHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RateVersion",curatedrate.RateVersion, DbType.Int32);
				sqlParams.Add("@CuratedRateValue",curatedrate.CuratedRateValue, DbType.Decimal);
				sqlParams.Add("@IsDynamicRate",curatedrate.IsDynamicRate, DbType.Boolean);
				sqlParams.Add("@RateTypeId",curatedrate.RateTypeId, DbType.Int32);
				sqlParams.Add("@CurationStatusId",curatedrate.CurationStatusId, DbType.Int32);
				sqlParams.Add("@CreatedBy",curatedrate.CreatedBy, DbType.AnsiString);
				sqlParams.Add("@ModifiedBy",curatedrate.ModifiedBy, DbType.AnsiString);
				sqlParams.Add("@RowVersion",curatedrate.RowVersion, DbType.Binary);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRApi.CuratedRateAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RateTypeAddUpdate(RateType ratetype)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RateTypeId",ratetype.RateTypeId, DbType.Int32);
				sqlParams.Add("@RateTypeName",ratetype.RateTypeName, DbType.AnsiString);
				sqlParams.Add("@RateTypeDescription",ratetype.RateTypeDescription, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRApi.RateTypeAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> CurationStatusAddUpdate(CurationStatus curationstatus)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@CurationStatusId",curationstatus.CurationStatusId, DbType.Int32);
				sqlParams.Add("@CurationStatusName",curationstatus.CurationStatusName, DbType.AnsiString);
				sqlParams.Add("@CurationStatusDescription",curationstatus.CurationStatusDescription, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRApi.CurationStatusAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<IList<Rate>> GetConfirmedRates(object sellableinventorylist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryList",sellableinventorylist, DbType.String);
				
				var result = await connection
				     .QueryAsync<Rate>(
				     "SIRApi.GetConfirmedRates",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		#endregion Methods
	}
}
