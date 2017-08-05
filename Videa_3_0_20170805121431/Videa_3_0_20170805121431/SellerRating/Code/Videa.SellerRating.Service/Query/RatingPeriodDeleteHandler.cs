using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class RatingPeriodDeleteHandler : IAsyncRequestHandler<RatingPeriodDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatingPeriodDeleteHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatingPeriodDeleteQuery message)
		{
			return await _dataService
				.RatingPeriodDelete(message.RatingPeriodHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
