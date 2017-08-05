using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.AvailMartNS.Service.Proto.Types;

namespace Videa.AvailMartNS.Service
{
	public class AvailMartServiceImpl : AvailMartService.AvailMartServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailMartServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<AvailMartDeleteResponse> AvailMartDelete(AvailMartDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new AvailMartDeleteQuery
			{
				AvailMartHashKey = request.AvailMartHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new AvailMartDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<AvailListDeleteResponse> AvailListDelete(AvailListDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new AvailListDeleteQuery
			{
				AvailListHashKey = request.AvailListHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new AvailListDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<AvailLineWithDetailedPeriodsDeleteResponse> AvailLineWithDetailedPeriodsDelete(AvailLineWithDetailedPeriodsDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new AvailLineWithDetailedPeriodsDeleteQuery
			{
				AvailLineWithDetailedPeriodsHashKey = request.AvailLineWithDetailedPeriodsHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new AvailLineWithDetailedPeriodsDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<DetailedPeriodDeleteResponse> DetailedPeriodDelete(DetailedPeriodDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new DetailedPeriodDeleteQuery
			{
				DetailedPeriodHashKey = request.DetailedPeriodHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new DetailedPeriodDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<AvailMartAddUpdateResponse> AvailMartAddUpdate(AvailMartAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new AvailMartAddUpdateQuery
			{
				AvailMart = request.AvailMart.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new AvailMartAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<AvailListAddUpdateResponse> AvailListAddUpdate(AvailListAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new AvailListAddUpdateQuery
			{
				AvailList = request.AvailList.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new AvailListAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<AvailLineWithDetailedPeriodsAddUpdateResponse> AvailLineWithDetailedPeriodsAddUpdate(AvailLineWithDetailedPeriodsAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new AvailLineWithDetailedPeriodsAddUpdateQuery
			{
				AvailLineWithDetailedPeriods = request.AvailLineWithDetailedPeriods.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new AvailLineWithDetailedPeriodsAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<DetailedPeriodAddUpdateResponse> DetailedPeriodAddUpdate(DetailedPeriodAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new DetailedPeriodAddUpdateQuery
			{
				DetailedPeriod = request.DetailedPeriod.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new DetailedPeriodAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<GetAvailMartResponse> GetAvailMart(GetAvailMartRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetAvailMartQuery
			{
				StationHashKey = request.StationHashKey,
				RateCardTypeHashKey = request.RateCardTypeHashKey,
				DaypartHashKey = request.DaypartHashKey,
				BroadcastWeekList = request.BroadcastWeekList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetAvailMartResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<BulkStoreResponse> BulkStore(BulkStoreRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new BulkStoreQuery
			{
				AvailMart = request.AvailMart.ToEntity(),
				AvailList = request.AvailList.ToEntity(),
				AvailLineWithDetailedPeriods = request.AvailLineWithDetailedPeriods.ToEntity(),
				DetailedPeriod = request.DetailedPeriod.ToEntity()
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
