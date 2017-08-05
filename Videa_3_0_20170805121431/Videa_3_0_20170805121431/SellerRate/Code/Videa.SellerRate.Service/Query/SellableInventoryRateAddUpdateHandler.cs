using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class SellableInventoryRateAddUpdateHandler : IAsyncRequestHandler<SellableInventoryRateAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryRateAddUpdateHandler(ISellerRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryRateAddUpdateQuery message)
		{
			return await _dataService
				.SellableInventoryRateAddUpdate(message.SellableInventoryRate)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
