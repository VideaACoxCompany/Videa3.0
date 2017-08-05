using System;
using System.Collections.Generic;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class BulkStoreQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public List<AvailMart> AvailMart
		{
			get;
			set;
		} 
		public List<AvailList> AvailList
		{
			get;
			set;
		} 
		public List<AvailLineWithDetailedPeriods> AvailLineWithDetailedPeriods
		{
			get;
			set;
		} 
		public List<DetailedPeriod> DetailedPeriod
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
