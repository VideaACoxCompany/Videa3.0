using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class RatingPeriodAddUpdateHandler : IAsyncRequestHandler<RatingPeriodAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISellerRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatingPeriodAddUpdateHandler(ISellerRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatingPeriodAddUpdateQuery message)
		{
			return await _dataService
				.RatingPeriodAddUpdate(message.RatingPeriod)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
