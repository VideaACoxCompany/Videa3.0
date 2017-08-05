using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class GetRateCardsByStationHandler : IAsyncRequestHandler<GetRateCardsByStationQuery, IList<RateCard>>
	{
		#region Fields
		private  readonly  ISellableInventoryMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetRateCardsByStationHandler(ISellableInventoryMartDataService dataService)
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
