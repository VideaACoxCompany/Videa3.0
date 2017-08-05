using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class CuratedRateAddUpdateHandler : IAsyncRequestHandler<CuratedRateAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRateAddUpdateHandler(ICuratedRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(CuratedRateAddUpdateQuery message)
		{
			return await _dataService
				.CuratedRateAddUpdate(message.CuratedRate)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
