using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellableInventoryAddUpdateHandler : IAsyncRequestHandler<SellableInventoryAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryAddUpdateHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryAddUpdateQuery message)
		{
			return await _dataService
				.SellableInventoryAddUpdate(message.SellableInventory)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
