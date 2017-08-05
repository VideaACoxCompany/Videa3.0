using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class AvailLineWithDetailedPeriodsDeleteHandler : IAsyncRequestHandler<AvailLineWithDetailedPeriodsDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailLineWithDetailedPeriodsDeleteHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(AvailLineWithDetailedPeriodsDeleteQuery message)
		{
			return await _dataService
				.AvailLineWithDetailedPeriodsDelete(message.AvailLineWithDetailedPeriodsHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
