using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class RateCardDaypartAddUpdateHandler : IAsyncRequestHandler<RateCardDaypartAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardDaypartAddUpdateHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateCardDaypartAddUpdateQuery message)
		{
			return await _dataService
				.RateCardDaypartAddUpdate(message.RateCardDaypart)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
