using System;
using System.Collections.Generic;
using Videa.AvailMartNS.Service.Proto.Types;

namespace Videa.AvailMartNS.Service
{
	public static class ProtoExtensions
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static Videa.AvailMartNS.Data.DataServices.AvailMart ToEntity(this AvailMart source)
		{
			return new Videa.AvailMartNS.Data.DataServices.AvailMart
			{
				AvailMartHashKey = source.AvailMartHashKey.ToCharArray(),
				AvailMartSqn = source.AvailMartSqn,
				StartDate = source.StartDate.ToDateTime(),
				EndDate = source.EndDate.ToDateTime()
			};

		}
		public  static Videa.AvailMartNS.Data.DataServices.AvailList ToEntity(this AvailList source)
		{
			return new Videa.AvailMartNS.Data.DataServices.AvailList
			{
				AvailListHashKey = source.AvailListHashKey.ToCharArray(),
				AvailListSqn = source.AvailListSqn,
				AvailMartHashKey = source.AvailMartHashKey.ToCharArray(),
				Name = source.Name,
				StartDate = source.StartDate.ToDateTime(),
				EndDate = source.EndDate.ToDateTime()
			};

		}
		public  static Videa.AvailMartNS.Data.DataServices.AvailLineWithDetailedPeriods ToEntity(this AvailLineWithDetailedPeriods source)
		{
			return new Videa.AvailMartNS.Data.DataServices.AvailLineWithDetailedPeriods
			{
				AvailLineWithDetailedPeriodsHashKey = source.AvailLineWithDetailedPeriodsHashKey.ToCharArray(),
				AvailLineWithDetailedPeriodsSqn = source.AvailLineWithDetailedPeriodsSqn,
				AvailListHashKey = source.AvailListHashKey.ToCharArray(),
				DaypartName = source.DaypartName,
				AvailName = source.AvailName
			};

		}
		public  static Videa.AvailMartNS.Data.DataServices.DetailedPeriod ToEntity(this DetailedPeriod source)
		{
			return new Videa.AvailMartNS.Data.DataServices.DetailedPeriod
			{
				DetailedPeriodHashKey = source.DetailedPeriodHashKey.ToCharArray(),
				DetailedPeriodSqn = source.DetailedPeriodSqn,
				AvailLineWithDetailedPeriodsHashKey = source.AvailLineWithDetailedPeriodsHashKey.ToCharArray(),
				StartDate = source.StartDate.ToDateTime(),
				EndDate = source.EndDate.ToDateTime(),
				Rate = Decimal.Parse(source.Rate)
			};

		}
		#endregion Methods
	}
}
