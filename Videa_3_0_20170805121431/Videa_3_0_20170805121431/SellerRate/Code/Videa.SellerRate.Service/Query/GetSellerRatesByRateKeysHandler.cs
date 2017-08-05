using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class GetSellerRatesByRateKeysHandler : IAsyncRequestHandler<GetSellerRatesByRateKeysQuery, IList<Rate>>
	{
		#region Fields
		private  readonly  ISellerRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetSellerRatesByRateKeysHandler(ISellerRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<Rate>> Handle(GetSellerRatesByRateKeysQuery message)
		{
			return await _dataService
				.GetSellerRatesByRateKeys(message.SellableInventoryRateList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
