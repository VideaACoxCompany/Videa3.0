using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class SellableInventoryRateAddUpdateHandler : IAsyncRequestHandler<SellableInventoryRateAddUpdateQuery, bool>
	{
		#region Fields
		private  readonly  ISharebuilderRateDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public SellableInventoryRateAddUpdateHandler(ISharebuilderRateDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(SellableInventoryRateAddUpdateQuery message)
		{
			return await _dataService
				.SellableInventoryRateAddUpdate(message.SellableInventoryRate)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
