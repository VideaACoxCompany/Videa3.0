using System;
using System.Collections.Generic;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class GetConfirmedRatingsQuery : IRequest<IList<Rating>>
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
