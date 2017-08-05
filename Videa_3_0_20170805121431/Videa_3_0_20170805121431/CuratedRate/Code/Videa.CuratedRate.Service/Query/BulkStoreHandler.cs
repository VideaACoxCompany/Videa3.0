using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class BulkStoreHandler : IAsyncRequestHandler<BulkStoreQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public BulkStoreHandler(ICuratedRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(BulkStoreQuery message)
		{
			return await _dataService
				.BulkStore(message.CuratedRate, message.RateType, message.CurationStatus, message.Rate)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
