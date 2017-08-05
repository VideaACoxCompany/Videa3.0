using System;
using System.Collections.Generic;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class GetTrafficStatisticsQuery : IRequest<IList<TrafficStatistic>>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.String SellableInventoryList
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
