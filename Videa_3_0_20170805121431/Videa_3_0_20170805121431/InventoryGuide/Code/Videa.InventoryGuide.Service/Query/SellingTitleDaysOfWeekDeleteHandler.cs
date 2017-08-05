using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class SellingTitleDaysOfWeekDeleteHandler : IAsyncRequestHandler<SellingTitleDaysOfWeekDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleDaysOfWeekDeleteHandler(IInventoryGuideDataService dataService)
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
