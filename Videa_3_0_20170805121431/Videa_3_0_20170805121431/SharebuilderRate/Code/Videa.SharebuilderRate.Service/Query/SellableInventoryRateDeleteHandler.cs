using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class SellableInventoryRateDeleteHandler : IAsyncRequestHandler<SellableInventoryRateDeleteQuery, bool>
	{
		#region Fields
		private  readonly  ISharebuilderRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryRateDeleteHandler(ISharebuilderRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryRateDeleteQuery message)
		{
			return await _dataService
				.SellableInventoryRateDelete(message.SellableInventoryRateHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
