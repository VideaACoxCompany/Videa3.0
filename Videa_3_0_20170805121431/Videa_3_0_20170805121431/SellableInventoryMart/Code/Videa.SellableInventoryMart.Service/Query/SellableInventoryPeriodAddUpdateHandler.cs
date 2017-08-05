using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellableInventoryPeriodAddUpdateHandler : IAsyncRequestHandler<SellableInventoryPeriodAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryPeriodAddUpdateHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryPeriodAddUpdateQuery message)
		{
			return await _dataService
				.SellableInventoryPeriodAddUpdate(message.SellableInventoryPeriod)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
