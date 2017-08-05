using System;
using System.Collections.Generic;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class SellableInventoryRatingAddUpdateQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public SellableInventoryRating SellableInventoryRating
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
