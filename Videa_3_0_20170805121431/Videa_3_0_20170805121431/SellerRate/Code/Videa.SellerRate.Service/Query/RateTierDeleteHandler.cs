using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class RateTierDeleteHandler : IAsyncRequestHandler<RateTierDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateTierDeleteHandler(ISellerRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateTierDeleteQuery message)
		{
			return await _dataService
				.RateTierDelete(message.RateTierHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
