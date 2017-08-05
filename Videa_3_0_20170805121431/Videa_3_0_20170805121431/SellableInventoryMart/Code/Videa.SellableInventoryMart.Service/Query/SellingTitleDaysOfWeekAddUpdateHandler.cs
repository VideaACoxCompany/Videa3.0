using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellingTitleDaysOfWeekAddUpdateHandler : IAsyncRequestHandler<SellingTitleDaysOfWeekAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleDaysOfWeekAddUpdateHandler(ISellableInventoryMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellingTitleDaysOfWeekAddUpdateQuery message)
		{
			return await _dataService
				.SellingTitleDaysOfWeekAddUpdate(message.SellingTitleDaysOfWeek)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
