using System;
using System.Collections.Generic;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class CurationStatusDeleteQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.Int32 CurationStatusId
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
