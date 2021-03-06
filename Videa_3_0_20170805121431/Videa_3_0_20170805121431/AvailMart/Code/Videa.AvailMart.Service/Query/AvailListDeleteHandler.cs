﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class AvailListDeleteHandler : IAsyncRequestHandler<AvailListDeleteQuery, bool>
	{
		#region Fields
		private  readonly  IAvailMartDataService _dataService;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public AvailListDeleteHandler(IAvailMartDataService dataService)
		{
			_dataService = dataService;
		}
		#endregion Constructors
		#region Methods
		public  async Task<bool> Handle(AvailListDeleteQuery message)
		{
			return await _dataService
				.AvailListDelete(message.AvailListHashKey)
				.ConfigureAwait(false);

		}
		#endregion Methods
	}
}
