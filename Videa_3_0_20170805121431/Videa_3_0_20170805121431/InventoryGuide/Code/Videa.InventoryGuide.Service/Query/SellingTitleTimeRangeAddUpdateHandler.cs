using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class SellingTitleTimeRangeAddUpdateHandler : IAsyncRequestHandler<SellingTitleTimeRangeAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleTimeRangeAddUpdateHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellingTitleTimeRangeAddUpdateQuery message)
		{
			return await _dataService
				.SellingTitleTimeRangeAddUpdate(message.SellingTitleTimeRange)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
