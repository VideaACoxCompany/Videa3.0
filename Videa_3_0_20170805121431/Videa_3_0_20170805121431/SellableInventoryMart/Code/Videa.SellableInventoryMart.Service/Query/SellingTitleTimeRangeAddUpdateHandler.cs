using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellingTitleTimeRangeAddUpdateHandler : IAsyncRequestHandler<SellingTitleTimeRangeAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleTimeRangeAddUpdateHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellingTitleTimeRangeAddUpdateQuery message)
		{
			return await _dataService
				.SellingTitleTimeRangeAddUpdate(message.SellingTitleTimeRange)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
