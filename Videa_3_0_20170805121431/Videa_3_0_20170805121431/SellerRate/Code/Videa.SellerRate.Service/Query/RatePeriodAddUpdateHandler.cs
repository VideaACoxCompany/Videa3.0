using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class RatePeriodAddUpdateHandler : IAsyncRequestHandler<RatePeriodAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatePeriodAddUpdateHandler(ISellerRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatePeriodAddUpdateQuery message)
		{
			return await _dataService
				.RatePeriodAddUpdate(message.RatePeriod)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
