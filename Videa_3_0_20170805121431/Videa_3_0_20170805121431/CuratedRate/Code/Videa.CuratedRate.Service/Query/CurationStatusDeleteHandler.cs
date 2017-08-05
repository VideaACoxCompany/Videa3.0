using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class CurationStatusDeleteHandler : IAsyncRequestHandler<CurationStatusDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CurationStatusDeleteHandler(ICuratedRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(CurationStatusDeleteQuery message)
		{
			return await _dataService
				.CurationStatusDelete(message.CurationStatusId)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
