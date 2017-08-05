using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.CuratedRatingNS.Service.Proto.Types;

namespace Videa.CuratedRatingNS.Service
{
	public class CuratedRatingServiceImpl : CuratedRatingService.CuratedRatingServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRatingServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<CuratedRatingDeleteResponse> CuratedRatingDelete(CuratedRatingDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CuratedRatingDeleteQuery
			{
				CuratedRatingId = request.CuratedRatingId
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CuratedRatingDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RatingTypeDeleteResponse> RatingTypeDelete(RatingTypeDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatingTypeDeleteQuery
			{
				RatingTypeId = request.RatingTypeId
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatingTypeDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<CurationStatusDeleteResponse> CurationStatusDelete(CurationStatusDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CurationStatusDeleteQuery
			{
				CurationStatusId = request.CurationStatusId
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CurationStatusDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<CuratedRatingAddUpdateResponse> CuratedRatingAddUpdate(CuratedRatingAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CuratedRatingAddUpdateQuery
			{
				CuratedRating = request.CuratedRating.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CuratedRatingAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RatingTypeAddUpdateResponse> RatingTypeAddUpdate(RatingTypeAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatingTypeAddUpdateQuery
			{
				RatingType = request.RatingType.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatingTypeAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<CurationStatusAddUpdateResponse> CurationStatusAddUpdate(CurationStatusAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CurationStatusAddUpdateQuery
			{
				CurationStatus = request.CurationStatus.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CurationStatusAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<GetConfirmedRatingsResponse> GetConfirmedRatings(GetConfirmedRatingsRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetConfirmedRatingsQuery
			{
				SellableInventoryList = request.SellableInventoryList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetConfirmedRatingsResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<BulkStoreResponse> BulkStore(BulkStoreRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new BulkStoreQuery
			{
				CuratedRating = request.CuratedRating.ToEntity(),
				RatingType = request.RatingType.ToEntity(),
				CurationStatus = request.CurationStatus.ToEntity(),
				Rating = request.Rating.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new BulkStoreResponse
			{ 
			};
			
			return result;

		}
		#endregion Methods
	}
}
