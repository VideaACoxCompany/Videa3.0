using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class AvailLineWithDetailedPeriodsAddUpdateHandler : IAsyncRequestHandler<AvailLineWithDetailedPeriodsAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailLineWithDetailedPeriodsAddUpdateHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(AvailLineWithDetailedPeriodsAddUpdateQuery message)
		{
			return await _dataService
				.AvailLineWithDetailedPeriodsAddUpdate(message.AvailLineWithDetailedPeriods)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
