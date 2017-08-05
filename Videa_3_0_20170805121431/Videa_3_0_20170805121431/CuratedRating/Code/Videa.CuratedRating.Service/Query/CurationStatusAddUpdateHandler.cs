using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class CurationStatusAddUpdateHandler : IAsyncRequestHandler<CurationStatusAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRatingDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CurationStatusAddUpdateHandler(ICuratedRatingDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(CurationStatusAddUpdateQuery message)
		{
			return await _dataService
				.CurationStatusAddUpdate(message.CurationStatus)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
