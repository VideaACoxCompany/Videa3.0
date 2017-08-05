using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class GetSellerRatingsByRatingKeysHandler : IAsyncRequestHandler<GetSellerRatingsByRatingKeysQuery, IList<Rating>>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetSellerRatingsByRatingKeysHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<Rating>> Handle(GetSellerRatingsByRatingKeysQuery message)
		{
			return await _dataService
				.GetSellerRatingsByRatingKeys(message.SellableInventoryRatingList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
