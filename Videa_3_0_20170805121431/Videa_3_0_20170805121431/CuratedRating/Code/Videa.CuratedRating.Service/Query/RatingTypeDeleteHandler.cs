using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class RatingTypeDeleteHandler : IAsyncRequestHandler<RatingTypeDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatingTypeDeleteHandler(ICuratedRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatingTypeDeleteQuery message)
		{
			return await _dataService
				.RatingTypeDelete(message.RatingTypeId)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
