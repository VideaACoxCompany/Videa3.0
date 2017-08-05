using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class RateTierAddUpdateHandler : IAsyncRequestHandler<RateTierAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateTierAddUpdateHandler(ISellerRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateTierAddUpdateQuery message)
		{
			return await _dataService
				.RateTierAddUpdate(message.RateTier)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
