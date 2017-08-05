using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class GetRateCardsByStationHandler : IAsyncRequestHandler<GetRateCardsByStationQuery, IList<RateCard>>
	{
		#region Fields
		private  readonly  IInventoryGuideDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetRateCardsByStationHandler(IInventoryGuideDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<RateCard>> Handle(GetRateCardsByStationQuery message)
		{
			return await _dataService
				.GetRateCardsByStation(message.StationHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
