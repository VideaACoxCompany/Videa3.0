using System;
using System.Collections.Generic;
using Videa.CuratedRatingNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.CuratedRatingNS.Service
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
		public  static List<Videa.CuratedRatingNS.Data.DataServices.CuratedRating> ToEntity(this RepeatedField<CuratedRating> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.CuratedRatingNS.Data.DataServices.RatingType> ToEntity(this RepeatedField<RatingType> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.CuratedRatingNS.Data.DataServices.CurationStatus> ToEntity(this RepeatedField<CurationStatus> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.CuratedRatingNS.Data.DataServices.Rating> ToEntity(this RepeatedField<Rating> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
