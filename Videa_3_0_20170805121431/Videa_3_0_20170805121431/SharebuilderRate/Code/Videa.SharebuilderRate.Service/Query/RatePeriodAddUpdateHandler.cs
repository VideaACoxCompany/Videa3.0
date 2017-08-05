using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class RatePeriodAddUpdateHandler : IAsyncRequestHandler<RatePeriodAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISharebuilderRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatePeriodAddUpdateHandler(ISharebuilderRateDataService dataService)
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
