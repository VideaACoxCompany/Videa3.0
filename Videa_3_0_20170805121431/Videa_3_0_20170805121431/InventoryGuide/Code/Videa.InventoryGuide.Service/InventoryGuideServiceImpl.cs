using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using System.Linq;
using Videa.InventoryGuideNS.Service.Proto.Types;

namespace Videa.InventoryGuideNS.Service
{
	public class InventoryGuideServiceImpl : InventoryGuideService.InventoryGuideServiceBase
	{
		#region Fields
		private  readonly  IMediatorExecutor _executor;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public InventoryGuideServiceImpl(IMediatorExecutor executor)
		{
			_executor = executor;
		}
		#endregion Constructors
		#region Methods
		public  override async Task<SellingTitleDeleteResponse> SellingTitleDelete(SellingTitleDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellingTitleDeleteQuery
			{
				SellingTitleHashKey = request.SellingTitleHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellingTitleDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<StationDeleteResponse> StationDelete(StationDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new StationDeleteQuery
			{
				StationHashKey = request.StationHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new StationDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<StationGroupDeleteResponse> StationGroupDelete(StationGroupDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new StationGroupDeleteQuery
			{
				StationGroupHashKey = request.StationGroupHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new StationGroupDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateCardDeleteResponse> RateCardDelete(RateCardDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateCardDeleteQuery
			{
				RateCardHashKey = request.RateCardHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateCardDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateCardDaypartDeleteResponse> RateCardDaypartDelete(RateCardDaypartDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateCardDaypartDeleteQuery
			{
				RateCardDaypartHashKey = request.RateCardDaypartHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateCardDaypartDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateCardTypeDeleteResponse> RateCardTypeDelete(RateCardTypeDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateCardTypeDeleteQuery
			{
				RateCardTypeHashKey = request.RateCardTypeHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateCardTypeDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellingTitleTimeRangeDeleteResponse> SellingTitleTimeRangeDelete(SellingTitleTimeRangeDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellingTitleTimeRangeDeleteQuery
			{
				SellingTitleTimeRangeHashKey = request.SellingTitleTimeRangeHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellingTitleTimeRangeDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellingTitleDaysOfWeekDeleteResponse> SellingTitleDaysOfWeekDelete(SellingTitleDaysOfWeekDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellingTitleDaysOfWeekDeleteQuery
			{
				SellingTitleDaysOfWeekHashKey = request.SellingTitleDaysOfWeekHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellingTitleDaysOfWeekDeleteResponse
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
		public  override async Task<SellableInventoryDeleteResponse> SellableInventoryDelete(SellableInventoryDeleteRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryDeleteQuery
			{
				SellableInventoryHashKey = request.SellableInventoryHashKey
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryDeleteResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellingTitleAddUpdateResponse> SellingTitleAddUpdate(SellingTitleAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellingTitleAddUpdateQuery
			{
				SellingTitle = request.SellingTitle.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellingTitleAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<StationAddUpdateResponse> StationAddUpdate(StationAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new StationAddUpdateQuery
			{
				Station = request.Station.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new StationAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<StationGroupAddUpdateResponse> StationGroupAddUpdate(StationGroupAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new StationGroupAddUpdateQuery
			{
				StationGroup = request.StationGroup.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new StationGroupAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateCardAddUpdateResponse> RateCardAddUpdate(RateCardAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateCardAddUpdateQuery
			{
				RateCard = request.RateCard.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateCardAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateCardDaypartAddUpdateResponse> RateCardDaypartAddUpdate(RateCardDaypartAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateCardDaypartAddUpdateQuery
			{
				RateCardDaypart = request.RateCardDaypart.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateCardDaypartAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<RateCardTypeAddUpdateResponse> RateCardTypeAddUpdate(RateCardTypeAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new RateCardTypeAddUpdateQuery
			{
				RateCardType = request.RateCardType.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new RateCardTypeAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellingTitleTimeRangeAddUpdateResponse> SellingTitleTimeRangeAddUpdate(SellingTitleTimeRangeAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellingTitleTimeRangeAddUpdateQuery
			{
				SellingTitleTimeRange = request.SellingTitleTimeRange.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellingTitleTimeRangeAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<SellingTitleDaysOfWeekAddUpdateResponse> SellingTitleDaysOfWeekAddUpdate(SellingTitleDaysOfWeekAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellingTitleDaysOfWeekAddUpdateQuery
			{
				SellingTitleDaysOfWeek = request.SellingTitleDaysOfWeek.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellingTitleDaysOfWeekAddUpdateResponse
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
		public  override async Task<SellableInventoryAddUpdateResponse> SellableInventoryAddUpdate(SellableInventoryAddUpdateRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new SellableInventoryAddUpdateQuery
			{
				SellableInventory = request.SellableInventory.ToEntity()
			}).ConfigureAwait(false);
			
			var returnVal = res;
			
			var result = new SellableInventoryAddUpdateResponse
			{ 
			};
			
			return result;

		}
		public  override async Task<GetRateCardsByStationResponse> GetRateCardsByStation(GetRateCardsByStationRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetRateCardsByStationQuery
			{
				StationHashKey = request.StationHashKey
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetRateCardsByStationResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<GetRateCardsByDateRangeResponse> GetRateCardsByDateRange(GetRateCardsByDateRangeRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetRateCardsByDateRangeQuery
			{
				StartDate = request.StartDate,
				EndDate = request.EndDate
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetRateCardsByDateRangeResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<GetUnconfirmedInventoryResponse> GetUnconfirmedInventory(GetUnconfirmedInventoryRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new GetUnconfirmedInventoryQuery
			{
				StationHashKey = request.StationHashKey,
				RateCardTypeHashKey = request.RateCardTypeHashKey,
				RateCardDaypartHashKey = request.RateCardDaypartHashKey,
				BroadcastWeekList = request.BroadcastWeekList
			}).ConfigureAwait(false);
			
			var query = res.FirstOrDefault();
			
			var result = query != null ? new GetUnconfirmedInventoryResponse
			{
			} : null;
			
			return result;

		}
		public  override async Task<BulkStoreResponse> BulkStore(BulkStoreRequest request, ServerCallContext context)
		{
			var res = await _executor.ExecuteAsync(new BulkStoreQuery
			{
				SellingTitle = request.SellingTitle.ToEntity(),
				Station = request.Station.ToEntity(),
				StationGroup = request.StationGroup.ToEntity(),
				RateCard = request.RateCard.ToEntity(),
				RateCardDaypart = request.RateCardDaypart.ToEntity(),
				RateCardType = request.RateCardType.ToEntity(),
				SellingTitleTimeRange = request.SellingTitleTimeRange.ToEntity(),
				SellingTitleDaysOfWeek = request.SellingTitleDaysOfWeek.ToEntity(),
				RatePeriod = request.RatePeriod.ToEntity(),
				SellableInventory = request.SellableInventory.ToEntity(),
				SellableInventoryDto = request.SellableInventoryDto.ToEntity()
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
