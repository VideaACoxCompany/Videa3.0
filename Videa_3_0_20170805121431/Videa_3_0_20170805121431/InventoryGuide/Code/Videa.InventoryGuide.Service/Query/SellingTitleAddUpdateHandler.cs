using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class SellingTitleAddUpdateHandler : IAsyncRequestHandler<SellingTitleAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleAddUpdateHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellingTitleAddUpdateQuery message)
		{
			return await _dataService
				.SellingTitleAddUpdate(message.SellingTitle)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
