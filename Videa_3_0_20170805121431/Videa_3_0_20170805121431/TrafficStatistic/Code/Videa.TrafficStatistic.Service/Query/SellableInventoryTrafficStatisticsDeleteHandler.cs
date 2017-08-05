using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class SellableInventoryTrafficStatisticsDeleteHandler : IAsyncRequestHandler<SellableInventoryTrafficStatisticsDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ITrafficStatisticDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryTrafficStatisticsDeleteHandler(ITrafficStatisticDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryTrafficStatisticsDeleteQuery message)
		{
			return await _dataService
				.SellableInventoryTrafficStatisticsDelete(message.SellableInventoryTrafficStatisticHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
