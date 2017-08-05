using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class BulkStoreHandler : IAsyncRequestHandler<BulkStoreQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public BulkStoreHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(BulkStoreQuery message)
		{
			return await _dataService
				.BulkStore(message.SellingTitle, message.Station, message.StationGroup, message.RateCard, message.RateCardDaypart, message.RateCardType, message.SellingTitleTimeRange, message.SellingTitleDaysOfWeek, message.RatePeriod, message.SellableInventory, message.SellableInventoryDto)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
