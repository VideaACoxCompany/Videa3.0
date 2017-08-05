using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class RateCardDaypartDeleteHandler : IAsyncRequestHandler<RateCardDaypartDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateCardDaypartDeleteHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateCardDaypartDeleteQuery message)
		{
			return await _dataService
				.RateCardDaypartDelete(message.RateCardDaypartHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
