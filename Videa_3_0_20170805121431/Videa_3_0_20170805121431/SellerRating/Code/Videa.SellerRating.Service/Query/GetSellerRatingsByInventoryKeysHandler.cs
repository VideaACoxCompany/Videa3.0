using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class GetSellerRatingsByInventoryKeysHandler : IAsyncRequestHandler<GetSellerRatingsByInventoryKeysQuery, IList<Rating>>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetSellerRatingsByInventoryKeysHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<Rating>> Handle(GetSellerRatingsByInventoryKeysQuery message)
		{
			return await _dataService
				.GetSellerRatingsByInventoryKeys(message.SellableInventoryList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
