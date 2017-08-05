using System;
using System.Collections.Generic;

namespace Videa.AvailMartNS.Data.DataServices
{
	public class DetailedPeriod
	{
		#region Fields
		#endregion Fields
		#region Properties
		public Char[] DetailedPeriodHashKey
		{
			get;
			set;
		} 
		public Int32 DetailedPeriodSqn
		{
			get;
			set;
		} 
		public Char[] AvailLineWithDetailedPeriodsHashKey
		{
			get;
			set;
		} 
		public DateTime StartDate
		{
			get;
			set;
		} 
		public DateTime EndDate
		{
			get;
			set;
		} 
		public Decimal Rate
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
