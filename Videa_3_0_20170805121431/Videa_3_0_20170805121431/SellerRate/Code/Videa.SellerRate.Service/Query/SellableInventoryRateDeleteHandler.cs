using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class SellableInventoryRateDeleteHandler : IAsyncRequestHandler<SellableInventoryRateDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryRateDeleteHandler(ISellerRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryRateDeleteQuery message)
		{
			return await _dataService
				.SellableInventoryRateDelete(message.SellableInventoryRateHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
