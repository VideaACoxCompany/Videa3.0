using System;
using System.Collections.Generic;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class BulkStoreQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public List<RateTier> RateTier
		{
			get;
			set;
		} 
		public List<RatePeriod> RatePeriod
		{
			get;
			set;
		} 
		public List<SellableInventoryRate> SellableInventoryRate
		{
			get;
			set;
		} 
		public List<Rate> Rate
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
