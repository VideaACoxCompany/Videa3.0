using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class RateTierAddUpdateHandler : IAsyncRequestHandler<RateTierAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISharebuilderRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateTierAddUpdateHandler(ISharebuilderRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateTierAddUpdateQuery message)
		{
			return await _dataService
				.RateTierAddUpdate(message.RateTier)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
