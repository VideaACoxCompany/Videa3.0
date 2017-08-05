using System;
using System.Collections.Generic;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class SellableInventoryPeriodDeleteQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.String SellableInventoryPeriodHashKey
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
