using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class RatePeriodDeleteHandler : IAsyncRequestHandler<RatePeriodDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatePeriodDeleteHandler(ISellerRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatePeriodDeleteQuery message)
		{
			return await _dataService
				.RatePeriodDelete(message.RatePeriodHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
