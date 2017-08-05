using System;
using System.Collections.Generic;
using Videa.SellerRatingNS.Service.Proto.Types;

namespace Videa.SellerRatingNS.Service
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
		public  static Videa.SellerRatingNS.Data.DataServices.RatingDemo ToEntity(this RatingDemo source)
		{
			return new Videa.SellerRatingNS.Data.DataServices.RatingDemo
			{
				RatingDemoHashKey = source.RatingDemoHashKey.ToCharArray(),
				RatingDemoSqn = source.RatingDemoSqn,
				RatingDemoName = source.RatingDemoName
			};

		}
		public  static Videa.SellerRatingNS.Data.DataServices.RatingPeriod ToEntity(this RatingPeriod source)
		{
			return new Videa.SellerRatingNS.Data.DataServices.RatingPeriod
			{
				RatingPeriodHashKey = source.RatingPeriodHashKey.ToCharArray(),
				RatingPeriodSqn = source.RatingPeriodSqn,
				RatingPeriodName = source.RatingPeriodName,
				RatingPeriodStartDate = source.RatingPeriodStartDate.ToDateTime(),
				RatingPeriodEndDate = source.RatingPeriodEndDate.ToDateTime()
			};

		}
		public  static Videa.SellerRatingNS.Data.DataServices.SellableInventoryRating ToEntity(this SellableInventoryRating source)
		{
			return new Videa.SellerRatingNS.Data.DataServices.SellableInventoryRating
			{
				SellableInventoryRatingHashKey = source.SellableInventoryRatingHashKey.ToCharArray(),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				SellableInventoryRatingSqn = source.SellableInventoryRatingSqn,
				RatingDemoHashKey = source.RatingDemoHashKey.ToCharArray(),
				RatingPeriodHashKey = source.RatingPeriodHashKey.ToCharArray(),
				SellableInventoryRatingValue = Decimal.Parse(source.SellableInventoryRatingValue),
				RowVersion = source.RowVersion
			};

		}
		public  static Videa.SellerRatingNS.Data.DataServices.Rating ToEntity(this Rating source)
		{
			return new Videa.SellerRatingNS.Data.DataServices.Rating
			{
				SellableInventoryRatingValue = Decimal.Parse(source.SellableInventoryRatingValue),
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				SellableInventoryRatingHashKey = source.SellableInventoryRatingHashKey.ToCharArray(),
				RatingDemoHashKey = source.RatingDemoHashKey.ToCharArray()
			};

		}
		#endregion Methods
	}
}
