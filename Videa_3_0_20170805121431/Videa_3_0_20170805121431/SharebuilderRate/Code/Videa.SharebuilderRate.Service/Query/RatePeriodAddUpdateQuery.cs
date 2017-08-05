using System;
using System.Collections.Generic;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class RatePeriodAddUpdateQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public RatePeriod RatePeriod
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
