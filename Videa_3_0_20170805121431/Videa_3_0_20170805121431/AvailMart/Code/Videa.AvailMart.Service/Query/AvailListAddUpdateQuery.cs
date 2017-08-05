using System;
using System.Collections.Generic;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class AvailListAddUpdateQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public AvailList AvailList
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
