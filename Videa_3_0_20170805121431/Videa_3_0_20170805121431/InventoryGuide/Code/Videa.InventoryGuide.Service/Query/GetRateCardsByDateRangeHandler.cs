using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class GetRateCardsByDateRangeHandler : IAsyncRequestHandler<GetRateCardsByDateRangeQuery, IList<RateCard>>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetRateCardsByDateRangeHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<RateCard>> Handle(GetRateCardsByDateRangeQuery message)
		{
			return await _dataService
				.GetRateCardsByDateRange(message.StartDate, message.EndDate)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
