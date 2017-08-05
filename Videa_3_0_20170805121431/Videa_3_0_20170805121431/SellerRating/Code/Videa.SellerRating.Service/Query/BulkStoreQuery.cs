using System;
using System.Collections.Generic;
using MediatR;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
{
	public class BulkStoreQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public List<RatingDemo> RatingDemo
		{
			get;
			set;
		} 
		public List<RatingPeriod> RatingPeriod
		{
			get;
			set;
		} 
		public List<SellableInventoryRating> SellableInventoryRating
		{
			get;
			set;
		} 
		public List<Rating> Rating
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
