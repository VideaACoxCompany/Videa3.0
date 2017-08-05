using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class GetAvailMartHandler : IAsyncRequestHandler<GetAvailMartQuery, IList<AvailMart>>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public GetAvailMartHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<IList<AvailMart>> Handle(GetAvailMartQuery message)
		{
			return await _dataService
				.GetAvailMart(message.StationHashKey, message.RateCardTypeHashKey, message.DaypartHashKey, message.BroadcastWeekList)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
