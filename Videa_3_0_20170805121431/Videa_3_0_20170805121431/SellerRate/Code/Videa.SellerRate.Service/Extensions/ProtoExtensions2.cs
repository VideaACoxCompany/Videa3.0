using System;
using System.Collections.Generic;
using Videa.SellerRateNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.SellerRateNS.Service
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
		public  static List<Videa.SellerRateNS.Data.DataServices.RateTier> ToEntity(this RepeatedField<RateTier> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellerRateNS.Data.DataServices.RatePeriod> ToEntity(this RepeatedField<RatePeriod> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellerRateNS.Data.DataServices.SellableInventoryRate> ToEntity(this RepeatedField<SellableInventoryRate> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellerRateNS.Data.DataServices.Rate> ToEntity(this RepeatedField<Rate> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
