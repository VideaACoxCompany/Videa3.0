using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellingTitleDaysOfWeekDeleteHandler : IAsyncRequestHandler<SellingTitleDaysOfWeekDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleDaysOfWeekDeleteHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellingTitleDaysOfWeekDeleteQuery message)
		{
			return await _dataService
				.SellingTitleDaysOfWeekDelete(message.SellingTitleDaysOfWeekHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
