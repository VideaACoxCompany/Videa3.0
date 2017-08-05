using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.SellerRatingNS.Service.Proto.Types;

namespace Videa.SellerRatingNS.Service
{
	public class SellerRatingServiceImpl : SellerRatingService.SellerRatingServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellerRatingServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<RatingDemoDeleteResponse> RatingDemoDelete(RatingDemoDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatingDemoDeleteQuery
			{
				RatingDemoHashKey = request.RatingDemoHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatingDemoDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RatingPeriodDeleteResponse> RatingPeriodDelete(RatingPeriodDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatingPeriodDeleteQuery
			{
				RatingPeriodHashKey = request.RatingPeriodHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatingPeriodDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellableInventoryRatingDeleteResponse> SellableInventoryRatingDelete(SellableInventoryRatingDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryRatingDeleteQuery
			{
				SellableInventoryRatingHashKey = request.SellableInventoryRatingHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryRatingDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RatingDemoAddUpdateResponse> RatingDemoAddUpdate(RatingDemoAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatingDemoAddUpdateQuery
			{
				RatingDemo = request.RatingDemo.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatingDemoAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RatingPeriodAddUpdateResponse> RatingPeriodAddUpdate(RatingPeriodAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatingPeriodAddUpdateQuery
			{
				RatingPeriod = request.RatingPeriod.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatingPeriodAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellableInventoryRatingAddUpdateResponse> SellableInventoryRatingAddUpdate(SellableInventoryRatingAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryRatingAddUpdateQuery
			{
				SellableInventoryRating = request.SellableInventoryRating.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryRatingAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<GetSellerRatingsByInventoryKeysResponse> GetSellerRatingsByInventoryKeys(GetSellerRatingsByInventoryKeysRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetSellerRatingsByInventoryKeysQuery
			{
				SellableInventoryList = request.SellableInventoryList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetSellerRatingsByInventoryKeysResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<GetSellerRatingsByRatingKeysResponse> GetSellerRatingsByRatingKeys(GetSellerRatingsByRatingKeysRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetSellerRatingsByRatingKeysQuery
			{
				SellableInventoryRatingList = request.SellableInventoryRatingList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetSellerRatingsByRatingKeysResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<BulkStoreResponse> BulkStore(BulkStoreRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new BulkStoreQuery
			{
				RatingDemo = request.RatingDemo.ToEntity(),
				RatingPeriod = request.RatingPeriod.ToEntity(),
				SellableInventoryRating = request.SellableInventoryRating.ToEntity(),
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
