using System;
using System.Collections.Generic;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class SellingTitleTimeRangeAddUpdateQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public SellingTitleTimeRange SellingTitleTimeRange
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
