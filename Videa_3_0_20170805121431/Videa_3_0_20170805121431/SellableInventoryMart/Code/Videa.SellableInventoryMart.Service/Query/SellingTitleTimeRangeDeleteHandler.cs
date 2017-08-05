using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellingTitleTimeRangeDeleteHandler : IAsyncRequestHandler<SellingTitleTimeRangeDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleTimeRangeDeleteHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellingTitleTimeRangeDeleteQuery message)
		{
			return await _dataService
				.SellingTitleTimeRangeDelete(message.SellingTitleTimeRangeHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
