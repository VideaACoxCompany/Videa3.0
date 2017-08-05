using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class GetConfirmedRatingsHandler : IAsyncRequestHandler<GetConfirmedRatingsQuery, IList<Rating>>
	{
		#region Fields
		private  readonly  ICuratedRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetConfirmedRatingsHandler(ICuratedRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<Rating>> Handle(GetConfirmedRatingsQuery message)
		{
			return await _dataService
				.GetConfirmedRatings(message.SellableInventoryList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
