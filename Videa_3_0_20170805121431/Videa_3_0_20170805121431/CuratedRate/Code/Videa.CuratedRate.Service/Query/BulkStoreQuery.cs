using System;
using System.Collections.Generic;
using MediatR;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
{
	public class BulkStoreQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public List<CuratedRate> CuratedRate
		{
			get;
			set;
		} 
		public List<RateType> RateType
		{
			get;
			set;
		} 
		public List<CurationStatus> CurationStatus
		{
			get;
			set;
		} 
		public List<Rate> Rate
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
