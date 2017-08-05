using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class SellableInventoryRatingAddUpdateHandler : IAsyncRequestHandler<SellableInventoryRatingAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryRatingAddUpdateHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryRatingAddUpdateQuery message)
		{
			return await _dataService
				.SellableInventoryRatingAddUpdate(message.SellableInventoryRating)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
