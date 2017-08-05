using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class CuratedRatingAddUpdateHandler : IAsyncRequestHandler<CuratedRatingAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRatingAddUpdateHandler(ICuratedRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(CuratedRatingAddUpdateQuery message)
		{
			return await _dataService
				.CuratedRatingAddUpdate(message.CuratedRating)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
