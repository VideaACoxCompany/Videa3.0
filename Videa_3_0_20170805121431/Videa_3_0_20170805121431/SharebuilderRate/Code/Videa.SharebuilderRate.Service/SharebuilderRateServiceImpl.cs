using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.SharebuilderRateNS.Service.Proto.Types;

namespace Videa.SharebuilderRateNS.Service
{
	public class SharebuilderRateServiceImpl : SharebuilderRateService.SharebuilderRateServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SharebuilderRateServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<RateTierDeleteResponse> RateTierDelete(RateTierDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateTierDeleteQuery
			{
				RateTierHashKey = request.RateTierHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateTierDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RatePeriodDeleteResponse> RatePeriodDelete(RatePeriodDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatePeriodDeleteQuery
			{
				RatePeriodHashKey = request.RatePeriodHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatePeriodDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellableInventoryRateDeleteResponse> SellableInventoryRateDelete(SellableInventoryRateDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryRateDeleteQuery
			{
				SellableInventoryRateHashKey = request.SellableInventoryRateHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryRateDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateTierAddUpdateResponse> RateTierAddUpdate(RateTierAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateTierAddUpdateQuery
			{
				RateTier = request.RateTier.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateTierAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RatePeriodAddUpdateResponse> RatePeriodAddUpdate(RatePeriodAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RatePeriodAddUpdateQuery
			{
				RatePeriod = request.RatePeriod.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RatePeriodAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellableInventoryRateAddUpdateResponse> SellableInventoryRateAddUpdate(SellableInventoryRateAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryRateAddUpdateQuery
			{
				SellableInventoryRate = request.SellableInventoryRate.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryRateAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<GetSharebuilderRatesResponse> GetSharebuilderRates(GetSharebuilderRatesRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetSharebuilderRatesQuery
			{
				SellableInventoryList = request.SellableInventoryList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetSharebuilderRatesResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<BulkStoreResponse> BulkStore(BulkStoreRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new BulkStoreQuery
			{
				RateTier = request.RateTier.ToEntity(),
				RatePeriod = request.RatePeriod.ToEntity(),
				SellableInventoryRate = request.SellableInventoryRate.ToEntity(),
				Rate = request.Rate.ToEntity()
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
