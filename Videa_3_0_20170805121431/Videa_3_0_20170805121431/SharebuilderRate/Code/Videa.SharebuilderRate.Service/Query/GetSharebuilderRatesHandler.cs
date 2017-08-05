using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class GetSharebuilderRatesHandler : IAsyncRequestHandler<GetSharebuilderRatesQuery, IList<Rate>>
	{
		#region Fields
		private  readonly  ISharebuilderRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetSharebuilderRatesHandler(ISharebuilderRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<Rate>> Handle(GetSharebuilderRatesQuery message)
		{
			return await _dataService
				.GetSharebuilderRates(message.SellableInventoryList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
