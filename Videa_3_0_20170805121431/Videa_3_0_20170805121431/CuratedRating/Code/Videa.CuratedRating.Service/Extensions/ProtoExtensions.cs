using System;
using System.Collections.Generic;
using Videa.CuratedRatingNS.Service.Proto.Types;

namespace Videa.CuratedRatingNS.Service
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
		public  static Videa.CuratedRatingNS.Data.DataServices.CuratedRating ToEntity(this CuratedRating source)
		{
			return new Videa.CuratedRatingNS.Data.DataServices.CuratedRating
			{
				CuratedRatingId = source.CuratedRatingId,
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				RatingHashKey = source.RatingHashKey.ToCharArray(),
				RatingVersion = source.RatingVersion,
				IsDynamicRating = source.IsDynamicRating,
				CuratingRatingValue = Decimal.Parse(source.CuratingRatingValue),
				RatingTypeId = source.RatingTypeId,
				CurationStatusId = source.CurationStatusId,
				CreatedBy = source.CreatedBy,
				ModifiedBy = source.ModifiedBy,
				RowVersion = source.RowVersion
			};

		}
		public  static Videa.CuratedRatingNS.Data.DataServices.RatingType ToEntity(this RatingType source)
		{
			return new Videa.CuratedRatingNS.Data.DataServices.RatingType
			{
				RatingTypeId = source.RatingTypeId,
				RatingTypeName = source.RatingTypeName,
				RatingTypeDescription = source.RatingTypeDescription
			};

		}
		public  static Videa.CuratedRatingNS.Data.DataServices.CurationStatus ToEntity(this CurationStatus source)
		{
			return new Videa.CuratedRatingNS.Data.DataServices.CurationStatus
			{
				CurationStatusId = source.CurationStatusId,
				CurationStatusName = source.CurationStatusName,
				CurationStatusDescription = source.CurationStatusDescription
			};

		}
		public  static Videa.CuratedRatingNS.Data.DataServices.Rating ToEntity(this Rating source)
		{
			return new Videa.CuratedRatingNS.Data.DataServices.Rating
			{
				todo = source.todo
			};

		}
		#endregion Methods
	}
}
