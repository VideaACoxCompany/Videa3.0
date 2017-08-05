using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class RateCardDeleteHandler : IAsyncRequestHandler<RateCardDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardDeleteHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateCardDeleteQuery message)
		{
			return await _dataService
				.RateCardDelete(message.RateCardHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
