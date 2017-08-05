using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class RatingDemoAddUpdateHandler : IAsyncRequestHandler<RatingDemoAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatingDemoAddUpdateHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatingDemoAddUpdateQuery message)
		{
			return await _dataService
				.RatingDemoAddUpdate(message.RatingDemo)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
