using System;
using System.Collections.Generic;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class GetSellerRatingsByInventoryKeysQuery : IRequest<IList<Rating>>
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
