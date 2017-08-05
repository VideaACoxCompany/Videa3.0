using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellableInventoryPeriodDeleteHandler : IAsyncRequestHandler<SellableInventoryPeriodDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryPeriodDeleteHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryPeriodDeleteQuery message)
		{
			return await _dataService
				.SellableInventoryPeriodDelete(message.SellableInventoryPeriodHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
