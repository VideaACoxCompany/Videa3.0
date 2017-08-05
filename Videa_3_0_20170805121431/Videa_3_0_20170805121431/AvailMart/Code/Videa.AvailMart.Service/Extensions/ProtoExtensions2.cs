using System;
using System.Collections.Generic;
using Videa.AvailMartNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.AvailMartNS.Service
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
		public  static List<Videa.AvailMartNS.Data.DataServices.AvailMart> ToEntity(this RepeatedField<AvailMart> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.AvailMartNS.Data.DataServices.AvailList> ToEntity(this RepeatedField<AvailList> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.AvailMartNS.Data.DataServices.AvailLineWithDetailedPeriods> ToEntity(this RepeatedField<AvailLineWithDetailedPeriods> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.AvailMartNS.Data.DataServices.DetailedPeriod> ToEntity(this RepeatedField<DetailedPeriod> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
