using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class RateCardAddUpdateHandler : IAsyncRequestHandler<RateCardAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardAddUpdateHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateCardAddUpdateQuery message)
		{
			return await _dataService
				.RateCardAddUpdate(message.RateCard)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
