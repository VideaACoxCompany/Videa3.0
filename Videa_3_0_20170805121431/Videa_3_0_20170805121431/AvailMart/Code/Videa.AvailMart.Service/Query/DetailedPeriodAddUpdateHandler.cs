using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class DetailedPeriodAddUpdateHandler : IAsyncRequestHandler<DetailedPeriodAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public DetailedPeriodAddUpdateHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(DetailedPeriodAddUpdateQuery message)
		{
			return await _dataService
				.DetailedPeriodAddUpdate(message.DetailedPeriod)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
