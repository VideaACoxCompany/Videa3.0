using System;
using System.Collections.Generic;
using MediatR;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
{
	public class CuratedRatingDeleteQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.Int64 CuratedRatingId
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
