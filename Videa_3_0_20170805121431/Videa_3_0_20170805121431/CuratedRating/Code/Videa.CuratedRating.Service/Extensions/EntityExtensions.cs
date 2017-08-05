using System;
using System.Collections.Generic;
using Videa.CuratedRatingNS.Service.Proto.Types;

namespace Videa.CuratedRatingNS.Service
{
	public static class EntityExtensions
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static CuratedRating ToProto(this Videa.CuratedRatingNS.Data.DataServices.CuratedRating source)
		{
			return new CuratedRating
			{
				CuratedRatingId = source.CuratedRatingId,
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				RatingHashKey = source.RatingHashKey.ToString(),
				RatingVersion = source.RatingVersion,
				IsDynamicRating = source.IsDynamicRating,
				CuratingRatingValue = source.CuratingRatingValue.ToString(),
				RatingTypeId = source.RatingTypeId,
				CurationStatusId = source.CurationStatusId,
				CreatedBy = source.CreatedBy,
				ModifiedBy = source.ModifiedBy,
				RowVersion = source.RowVersion
			};

		}
		public  static RatingType ToProto(this Videa.CuratedRatingNS.Data.DataServices.RatingType source)
		{
			return new RatingType
			{
				RatingTypeId = source.RatingTypeId,
				RatingTypeName = source.RatingTypeName,
				RatingTypeDescription = source.RatingTypeDescription
			};

		}
		public  static CurationStatus ToProto(this Videa.CuratedRatingNS.Data.DataServices.CurationStatus source)
		{
			return new CurationStatus
			{
				CurationStatusId = source.CurationStatusId,
				CurationStatusName = source.CurationStatusName,
				CurationStatusDescription = source.CurationStatusDescription
			};

		}
		public  static Rating ToProto(this Videa.CuratedRatingNS.Data.DataServices.Rating source)
		{
			return new Rating
			{
				todo = source.todo
			};

		}
		#endregion Methods
	}
}
