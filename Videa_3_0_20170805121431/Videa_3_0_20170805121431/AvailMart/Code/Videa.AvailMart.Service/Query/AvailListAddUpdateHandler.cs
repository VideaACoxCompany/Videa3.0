using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class AvailListAddUpdateHandler : IAsyncRequestHandler<AvailListAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailListAddUpdateHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(AvailListAddUpdateQuery message)
		{
			return await _dataService
				.AvailListAddUpdate(message.AvailList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
