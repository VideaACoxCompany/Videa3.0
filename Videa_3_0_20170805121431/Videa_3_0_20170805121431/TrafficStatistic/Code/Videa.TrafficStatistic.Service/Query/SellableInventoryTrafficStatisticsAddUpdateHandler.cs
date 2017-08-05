using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class SellableInventoryTrafficStatisticsAddUpdateHandler : IAsyncRequestHandler<SellableInventoryTrafficStatisticsAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ITrafficStatisticDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryTrafficStatisticsAddUpdateHandler(ITrafficStatisticDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryTrafficStatisticsAddUpdateQuery message)
		{
			return await _dataService
				.SellableInventoryTrafficStatisticsAddUpdate(message.SellableInventoryTrafficStatistics)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
