using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class BulkStoreHandler : IAsyncRequestHandler<BulkStoreQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public BulkStoreHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(BulkStoreQuery message)
		{
			return await _dataService
				.BulkStore(message.SellingTitle, message.Station, message.StationGroup, message.RateCard, message.RateCardDaypart, message.RateCardType, message.SellingTitleTimeRange, message.SellingTitleDaysOfWeek, message.SellableInventoryPeriod, message.SellableInventory, message.SellableInventoryDto)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
