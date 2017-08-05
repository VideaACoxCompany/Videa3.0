using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class BulkStoreHandler : IAsyncRequestHandler<BulkStoreQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public BulkStoreHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(BulkStoreQuery message)
		{
			return await _dataService
				.BulkStore(message.RatingDemo, message.RatingPeriod, message.SellableInventoryRating, message.Rating)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
