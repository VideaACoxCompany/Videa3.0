using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class AvailMartDeleteHandler : IAsyncRequestHandler<AvailMartDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailMartDeleteHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(AvailMartDeleteQuery message)
		{
			return await _dataService
				.AvailMartDelete(message.AvailMartHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
