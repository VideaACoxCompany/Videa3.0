using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class RateTypeDeleteHandler : IAsyncRequestHandler<RateTypeDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ICuratedRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateTypeDeleteHandler(ICuratedRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateTypeDeleteQuery message)
		{
			return await _dataService
				.RateTypeDelete(message.RateTypeId)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
