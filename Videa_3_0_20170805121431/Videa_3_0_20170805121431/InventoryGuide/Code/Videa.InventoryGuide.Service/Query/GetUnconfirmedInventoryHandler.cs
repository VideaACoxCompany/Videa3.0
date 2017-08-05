using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class GetUnconfirmedInventoryHandler : IAsyncRequestHandler<GetUnconfirmedInventoryQuery, IList<SellableInventoryDto>>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetUnconfirmedInventoryHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<SellableInventoryDto>> Handle(GetUnconfirmedInventoryQuery message)
		{
			return await _dataService
				.GetUnconfirmedInventory(message.StationHashKey, message.RateCardTypeHashKey, message.RateCardDaypartHashKey, message.BroadcastWeekList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
