using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class SellableInventoryRatingDeleteHandler : IAsyncRequestHandler<SellableInventoryRatingDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryRatingDeleteHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryRatingDeleteQuery message)
		{
			return await _dataService
				.SellableInventoryRatingDelete(message.SellableInventoryRatingHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
