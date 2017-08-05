using System;
using System.Collections.Generic;
using MediatR;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
{
	public class BulkStoreQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public List<RatePeriod> RatePeriod
		{
			get;
			set;
		} 
		public List<SellableInventoryTrafficStatistics> SellableInventoryTrafficStatistics
		{
			get;
			set;
		} 
		public List<TrafficStatistic> TrafficStatistic
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
