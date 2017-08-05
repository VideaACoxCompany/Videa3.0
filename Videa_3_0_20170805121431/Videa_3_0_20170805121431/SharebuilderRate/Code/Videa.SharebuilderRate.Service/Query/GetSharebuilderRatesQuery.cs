using System;
using System.Collections.Generic;
using MediatR;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
{
	public class GetSharebuilderRatesQuery : IRequest<IList<Rate>>
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
