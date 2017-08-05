using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class RatePeriodDeleteHandler : IAsyncRequestHandler<RatePeriodDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISharebuilderRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RatePeriodDeleteHandler(ISharebuilderRateDataService dataService)
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
