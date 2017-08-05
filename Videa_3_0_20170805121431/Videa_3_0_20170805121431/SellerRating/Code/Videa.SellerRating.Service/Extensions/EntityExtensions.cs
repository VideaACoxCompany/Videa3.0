using System;
using System.Collections.Generic;
using Videa.SellerRatingNS.Service.Proto.Types;

namespace Videa.SellerRatingNS.Service
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
		public  static RatingDemo ToProto(this Videa.SellerRatingNS.Data.DataServices.RatingDemo source)
		{
			return new RatingDemo
			{
				RatingDemoHashKey = source.RatingDemoHashKey.ToString(),
				RatingDemoSqn = source.RatingDemoSqn,
				RatingDemoName = source.RatingDemoName
			};

		}
		public  static RatingPeriod ToProto(this Videa.SellerRatingNS.Data.DataServices.RatingPeriod source)
		{
			return new RatingPeriod
			{
				RatingPeriodHashKey = source.RatingPeriodHashKey.ToString(),
				RatingPeriodSqn = source.RatingPeriodSqn,
				RatingPeriodName = source.RatingPeriodName,
				RatingPeriodStartDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.RatingPeriodStartDate),
				RatingPeriodEndDate = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(source.RatingPeriodEndDate)
			};

		}
		public  static SellableInventoryRating ToProto(this Videa.SellerRatingNS.Data.DataServices.SellableInventoryRating source)
		{
			return new SellableInventoryRating
			{
				SellableInventoryRatingHashKey = source.SellableInventoryRatingHashKey.ToString(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				SellableInventoryRatingSqn = source.SellableInventoryRatingSqn,
				RatingDemoHashKey = source.RatingDemoHashKey.ToString(),
				RatingPeriodHashKey = source.RatingPeriodHashKey.ToString(),
				SellableInventoryRatingValue = source.SellableInventoryRatingValue.ToString(),
				RowVersion = source.RowVersion
			};

		}
		public  static Rating ToProto(this Videa.SellerRatingNS.Data.DataServices.Rating source)
		{
			return new Rating
			{
				SellableInventoryRatingValue = source.SellableInventoryRatingValue.ToString(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				SellableInventoryRatingHashKey = source.SellableInventoryRatingHashKey.ToString(),
				RatingDemoHashKey = source.RatingDemoHashKey.ToString()
			};

		}
		#endregion Methods
	}
}
