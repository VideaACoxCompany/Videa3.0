using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class CuratedRatingDeleteHandler : IAsyncRequestHandler<CuratedRatingDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRatingDeleteHandler(ICuratedRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(CuratedRatingDeleteQuery message)
		{
			return await _dataService
				.CuratedRatingDelete(message.CuratedRatingId)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
