using System;
using System.Collections.Generic;
using Videa.CuratedRateNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.CuratedRateNS.Service
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
		public  static List<Videa.CuratedRateNS.Data.DataServices.CuratedRate> ToEntity(this RepeatedField<CuratedRate> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.CuratedRateNS.Data.DataServices.RateType> ToEntity(this RepeatedField<RateType> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.CuratedRateNS.Data.DataServices.CurationStatus> ToEntity(this RepeatedField<CurationStatus> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.CuratedRateNS.Data.DataServices.Rate> ToEntity(this RepeatedField<Rate> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
