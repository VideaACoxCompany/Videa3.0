using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.CuratedRateNS.Service.Proto.Types;

namespace Videa.CuratedRateNS.Service
{
	public class CuratedRateServiceImpl : CuratedRateService.CuratedRateServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRateServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<CuratedRateDeleteResponse> CuratedRateDelete(CuratedRateDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CuratedRateDeleteQuery
			{
				CuratedRateId = request.CuratedRateId
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CuratedRateDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateTypeDeleteResponse> RateTypeDelete(RateTypeDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateTypeDeleteQuery
			{
				RateTypeId = request.RateTypeId
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateTypeDeleteResponse
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
		public  override async Task<CuratedRateAddUpdateResponse> CuratedRateAddUpdate(CuratedRateAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new CuratedRateAddUpdateQuery
			{
				CuratedRate = request.CuratedRate.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new CuratedRateAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateTypeAddUpdateResponse> RateTypeAddUpdate(RateTypeAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateTypeAddUpdateQuery
			{
				RateType = request.RateType.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateTypeAddUpdateResponse
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
		public  override async Task<GetConfirmedRatesResponse> GetConfirmedRates(GetConfirmedRatesRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetConfirmedRatesQuery
			{
				SellableInventoryList = request.SellableInventoryList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetConfirmedRatesResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<BulkStoreResponse> BulkStore(BulkStoreRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new BulkStoreQuery
			{
				CuratedRate = request.CuratedRate.ToEntity(),
				RateType = request.RateType.ToEntity(),
				CurationStatus = request.CurationStatus.ToEntity(),
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
