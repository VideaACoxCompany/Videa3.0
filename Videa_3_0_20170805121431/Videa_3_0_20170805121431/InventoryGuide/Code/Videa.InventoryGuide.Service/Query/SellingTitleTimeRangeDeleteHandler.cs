using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class SellingTitleTimeRangeDeleteHandler : IAsyncRequestHandler<SellingTitleTimeRangeDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleTimeRangeDeleteHandler(IInventoryGuideDataService dataService)
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
