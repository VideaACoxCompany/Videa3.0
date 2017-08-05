using System;
using System.Collections.Generic;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class GetConfirmedRatesQuery : IRequest<IList<Rate>>
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
