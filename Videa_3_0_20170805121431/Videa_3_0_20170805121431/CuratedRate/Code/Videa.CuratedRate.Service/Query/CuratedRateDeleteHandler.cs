using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class CuratedRateDeleteHandler : IAsyncRequestHandler<CuratedRateDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRateDeleteHandler(ICuratedRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(CuratedRateDeleteQuery message)
		{
			return await _dataService
				.CuratedRateDelete(message.CuratedRateId)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
