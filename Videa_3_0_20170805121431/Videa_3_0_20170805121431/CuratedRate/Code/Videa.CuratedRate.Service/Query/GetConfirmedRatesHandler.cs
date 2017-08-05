using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class GetConfirmedRatesHandler : IAsyncRequestHandler<GetConfirmedRatesQuery, IList<Rate>>
	{
		#region Fields
		private  readonly  ICuratedRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetConfirmedRatesHandler(ICuratedRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<Rate>> Handle(GetConfirmedRatesQuery message)
		{
			return await _dataService
				.GetConfirmedRates(message.SellableInventoryList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
