using System;
using System.Collections.Generic;
using Videa.TrafficStatisticNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.TrafficStatisticNS.Service
{
	public static class ProtoExtensions2
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static List<Videa.TrafficStatisticNS.Data.DataServices.RatePeriod> ToEntity(this RepeatedField<RatePeriod> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.TrafficStatisticNS.Data.DataServices.SellableInventoryTrafficStatistics> ToEntity(this RepeatedField<SellableInventoryTrafficStatistics> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.TrafficStatisticNS.Data.DataServices.TrafficStatistic> ToEntity(this RepeatedField<TrafficStatistic> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
