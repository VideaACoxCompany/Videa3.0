using System;
using System.Collections.Generic;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class RatingPeriodAddUpdateQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public RatingPeriod RatingPeriod
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
