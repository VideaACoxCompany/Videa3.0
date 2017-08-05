using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class SellingTitleDeleteHandler : IAsyncRequestHandler<SellingTitleDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellingTitleDeleteHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellingTitleDeleteQuery message)
		{
			return await _dataService
				.SellingTitleDelete(message.SellingTitleHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
