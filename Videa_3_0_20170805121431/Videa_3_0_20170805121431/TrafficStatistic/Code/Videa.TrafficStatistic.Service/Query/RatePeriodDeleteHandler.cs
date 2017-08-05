using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class RatePeriodDeleteHandler : IAsyncRequestHandler<RatePeriodDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ITrafficStatisticDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatePeriodDeleteHandler(ITrafficStatisticDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RatePeriodDeleteQuery message)
		{
			return await _dataService
				.RatePeriodDelete(message.RatePeriodHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
