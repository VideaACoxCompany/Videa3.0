﻿using System;
using System.Collections.Generic;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class DetailedPeriodAddUpdateQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public DetailedPeriod DetailedPeriod
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
