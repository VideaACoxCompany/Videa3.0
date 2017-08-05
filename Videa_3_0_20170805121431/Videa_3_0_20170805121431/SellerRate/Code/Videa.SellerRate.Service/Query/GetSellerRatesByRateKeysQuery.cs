using System;
using System.Collections.Generic;
using MediatR;
using Videa.SellerRateNS.Data.DataServices;

namespace Videa.SellerRateNS.Service
{
	public class GetSellerRatesByRateKeysQuery : IRequest<IList<Rate>>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.String SellableInventoryRateList
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
