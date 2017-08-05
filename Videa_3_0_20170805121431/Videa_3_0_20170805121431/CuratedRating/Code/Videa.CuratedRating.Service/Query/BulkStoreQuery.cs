using System;
using System.Collections.Generic;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class BulkStoreQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public List<CuratedRating> CuratedRating
		{
			get;
			set;
		} 
		public List<RatingType> RatingType
		{
			get;
			set;
		} 
		public List<CurationStatus> CurationStatus
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
