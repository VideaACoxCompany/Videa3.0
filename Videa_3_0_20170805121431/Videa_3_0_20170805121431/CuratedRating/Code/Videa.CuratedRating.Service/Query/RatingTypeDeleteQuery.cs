using System;
using System.Collections.Generic;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class RatingTypeDeleteQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.Int32 RatingTypeId
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
