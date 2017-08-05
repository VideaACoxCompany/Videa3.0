using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class RateCardDaypartDeleteHandler : IAsyncRequestHandler<RateCardDaypartDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardDaypartDeleteHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateCardDaypartDeleteQuery message)
		{
			return await _dataService
				.RateCardDaypartDelete(message.RateCardDaypartHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
