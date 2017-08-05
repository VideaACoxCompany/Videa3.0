using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class RateCardTypeAddUpdateHandler : IAsyncRequestHandler<RateCardTypeAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardTypeAddUpdateHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateCardTypeAddUpdateQuery message)
		{
			return await _dataService
				.RateCardTypeAddUpdate(message.RateCardType)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
