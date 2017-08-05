using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class RatePeriodAddUpdateHandler : IAsyncRequestHandler<RatePeriodAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ITrafficStatisticDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatePeriodAddUpdateHandler(ITrafficStatisticDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatePeriodAddUpdateQuery message)
		{
			return await _dataService
				.RatePeriodAddUpdate(message.RatePeriod)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
