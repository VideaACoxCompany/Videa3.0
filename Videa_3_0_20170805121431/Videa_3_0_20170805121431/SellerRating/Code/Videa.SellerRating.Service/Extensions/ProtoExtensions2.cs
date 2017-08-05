using System;
using System.Collections.Generic;
using Videa.SellerRatingNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.SellerRatingNS.Service
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
		public  static List<Videa.SellerRatingNS.Data.DataServices.RatingDemo> ToEntity(this RepeatedField<RatingDemo> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellerRatingNS.Data.DataServices.RatingPeriod> ToEntity(this RepeatedField<RatingPeriod> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellerRatingNS.Data.DataServices.SellableInventoryRating> ToEntity(this RepeatedField<SellableInventoryRating> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellerRatingNS.Data.DataServices.Rating> ToEntity(this RepeatedField<Rating> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
