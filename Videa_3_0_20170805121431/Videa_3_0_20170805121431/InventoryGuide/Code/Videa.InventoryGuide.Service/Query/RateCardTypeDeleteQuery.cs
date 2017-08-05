using System;
using System.Collections.Generic;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class RateCardTypeDeleteQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.String RateCardTypeHashKey
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
