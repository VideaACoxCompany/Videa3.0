using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class BulkStoreHandler : IAsyncRequestHandler<BulkStoreQuery, bool>
	{
		#region Fields
		private  readonly  ITrafficStatisticDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public BulkStoreHandler(ITrafficStatisticDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(BulkStoreQuery message)
		{
			return await _dataService
				.BulkStore(message.RatePeriod, message.SellableInventoryTrafficStatistics, message.TrafficStatistic)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
