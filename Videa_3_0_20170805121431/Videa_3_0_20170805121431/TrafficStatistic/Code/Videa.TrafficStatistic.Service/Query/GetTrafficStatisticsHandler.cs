using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class GetTrafficStatisticsHandler : IAsyncRequestHandler<GetTrafficStatisticsQuery, IList<TrafficStatistic>>
	{
		#region Fields
		private  readonly  ITrafficStatisticDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetTrafficStatisticsHandler(ITrafficStatisticDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<TrafficStatistic>> Handle(GetTrafficStatisticsQuery message)
		{
			return await _dataService
				.GetTrafficStatistics(message.SellableInventoryList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
