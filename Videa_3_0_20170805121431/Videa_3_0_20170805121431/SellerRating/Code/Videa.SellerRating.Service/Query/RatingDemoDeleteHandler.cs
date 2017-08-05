using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class RatingDemoDeleteHandler : IAsyncRequestHandler<RatingDemoDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatingDemoDeleteHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatingDemoDeleteQuery message)
		{
			return await _dataService
				.RatingDemoDelete(message.RatingDemoHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
