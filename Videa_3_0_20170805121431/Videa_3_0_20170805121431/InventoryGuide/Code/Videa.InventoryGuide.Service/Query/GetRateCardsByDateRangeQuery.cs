﻿using System;
using System.Collections.Generic;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class GetRateCardsByDateRangeQuery : IRequest<IList<RateCard>>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.DateTime StartDate
		{
			get;
			set;
		} 
		public System.DateTime EndDate
		{
			get;
			set;
		} 
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}