using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class DetailedPeriodDeleteHandler : IAsyncRequestHandler<DetailedPeriodDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public DetailedPeriodDeleteHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(DetailedPeriodDeleteQuery message)
		{
			return await _dataService
				.DetailedPeriodDelete(message.DetailedPeriodHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
