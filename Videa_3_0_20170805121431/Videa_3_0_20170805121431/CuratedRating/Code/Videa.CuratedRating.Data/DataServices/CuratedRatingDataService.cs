using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Data.DataServices
{
	public class CuratedRatingDataService : BaseDataService, ICuratedRatingDataService
	{
		#region Fields
		private    int DefaultPageNumber;
		private    int DefaultPageSize;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRatingDataService(ICuratedRatingDbProvider dbProvider) : base(dbProvider)
		{
			//empty constructor
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> CuratedRatingDelete(System.Int64 curatedratingid)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@CuratedRatingId",curatedratingid, DbType.Int64);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRgApi.CuratedRatingDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RatingTypeDelete(System.Int32 ratingtypeid)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatingTypeId",ratingtypeid, DbType.Int32);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRgApi.RatingTypeDelete",
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
				     "SIRgApi.CurationStatusDelete",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> CuratedRatingAddUpdate(CuratedRating curatedrating)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@CuratedRatingId",curatedrating.CuratedRatingId, DbType.Int32);
				sqlParams.Add("@SellableInventoryHashKey",curatedrating.SellableInventoryHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RatingHashKey",curatedrating.RatingHashKey, DbType.AnsiStringFixedLength);
				sqlParams.Add("@RatingVersion",curatedrating.RatingVersion, DbType.Int32);
				sqlParams.Add("@IsDynamicRating",curatedrating.IsDynamicRating, DbType.Boolean);
				sqlParams.Add("@CuratingRatingValue",curatedrating.CuratingRatingValue, DbType.Decimal);
				sqlParams.Add("@RatingTypeId",curatedrating.RatingTypeId, DbType.Int32);
				sqlParams.Add("@CurationStatusId",curatedrating.CurationStatusId, DbType.Int32);
				sqlParams.Add("@CreatedBy",curatedrating.CreatedBy, DbType.AnsiString);
				sqlParams.Add("@ModifiedBy",curatedrating.ModifiedBy, DbType.AnsiString);
				sqlParams.Add("@RowVersion",curatedrating.RowVersion, DbType.Binary);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRgApi.CuratedRatingAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<bool> RatingTypeAddUpdate(RatingType ratingtype)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@RatingTypeId",ratingtype.RatingTypeId, DbType.Int32);
				sqlParams.Add("@RatingTypeName",ratingtype.RatingTypeName, DbType.AnsiString);
				sqlParams.Add("@RatingTypeDescription",ratingtype.RatingTypeDescription, DbType.AnsiString);
				
				var result = await connection
				     .ExecuteAsync(
				     "SIRgApi.RatingTypeAddUpdate",
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
				     "SIRgApi.CurationStatusAddUpdate",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result > 0;
			}

		}
		public  async Task<IList<Rating>> GetConfirmedRatings(object sellableinventorylist)
		{
			using (var connection = DbProvider.GetConnection())
			{
				var sqlParams = new DynamicParameters();
				sqlParams.Add("@SellableInventoryList",sellableinventorylist, DbType.String);
				
				var result = await connection
				     .QueryAsync<Rating>(
				     "SIRgApi.GetConfirmedRatings",
				        sqlParams,
				        commandType: CommandType.StoredProcedure)
				     .ConfigureAwait(false);
				
				return result.ToList();
			}

		}
		#endregion Methods
	}
}
