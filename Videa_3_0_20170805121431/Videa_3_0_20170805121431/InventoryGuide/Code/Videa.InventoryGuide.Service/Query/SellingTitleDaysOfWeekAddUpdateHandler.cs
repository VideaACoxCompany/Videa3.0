using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class SellingTitleDaysOfWeekAddUpdateHandler : IAsyncRequestHandler<SellingTitleDaysOfWeekAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleDaysOfWeekAddUpdateHandler(IInventoryGuideDataService dataService)
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
