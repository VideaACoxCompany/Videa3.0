using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class GetConfirmedInventoryHandler : IAsyncRequestHandler<GetConfirmedInventoryQuery, IList<SellableInventoryDto>>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetConfirmedInventoryHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<SellableInventoryDto>> Handle(GetConfirmedInventoryQuery message)
		{
			return await _dataService
				.GetConfirmedInventory(message.StationList, message.RateCardTypeHashKey, message.RateCardDaypartList, message.SellingTitleList, message.BroadcastWeekList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
