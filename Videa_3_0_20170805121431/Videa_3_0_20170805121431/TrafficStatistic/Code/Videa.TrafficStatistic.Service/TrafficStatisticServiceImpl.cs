using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.TrafficStatisticNS.Service.Proto.Types;

namespace Videa.TrafficStatisticNS.Service
{
	public class TrafficStatisticServiceImpl : TrafficStatisticService.TrafficStatisticServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public TrafficStatisticServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
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
		public  override async Task<SellableInventoryTrafficStatisticsDeleteResponse> SellableInventoryTrafficStatisticsDelete(SellableInventoryTrafficStatisticsDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryTrafficStatisticsDeleteQuery
			{
				SellableInventoryTrafficStatisticHashKey = request.SellableInventoryTrafficStatisticHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryTrafficStatisticsDeleteResponse
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
		public  override async Task<SellableInventoryTrafficStatisticsAddUpdateResponse> SellableInventoryTrafficStatisticsAddUpdate(SellableInventoryTrafficStatisticsAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryTrafficStatisticsAddUpdateQuery
			{
				SellableInventoryTrafficStatistics = request.SellableInventoryTrafficStatistics.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryTrafficStatisticsAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<GetTrafficStatisticsResponse> GetTrafficStatistics(GetTrafficStatisticsRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetTrafficStatisticsQuery
			{
				SellableInventoryList = request.SellableInventoryList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetTrafficStatisticsResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<BulkStoreResponse> BulkStore(BulkStoreRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new BulkStoreQuery
			{
				RatePeriod = request.RatePeriod.ToEntity(),
				SellableInventoryTrafficStatistics = request.SellableInventoryTrafficStatistics.ToEntity(),
				TrafficStatistic = request.TrafficStatistic.ToEntity()
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
