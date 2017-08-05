using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class RateTierDeleteHandler : IAsyncRequestHandler<RateTierDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISharebuilderRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public RateTierDeleteHandler(ISharebuilderRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(RateTierDeleteQuery message)
		{
			return await _dataService
				.RateTierDelete(message.RateTierHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
