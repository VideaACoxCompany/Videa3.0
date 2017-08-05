using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class StationDeleteHandler : IAsyncRequestHandler<StationDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public StationDeleteHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(StationDeleteQuery message)
		{
			return await _dataService
				.StationDelete(message.StationHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
