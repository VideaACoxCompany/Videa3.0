using System;
using System.Collections.Generic;
using Videa.CuratedRateNS.Service.Proto.Types;

namespace Videa.CuratedRateNS.Service
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
		public  static CuratedRate ToProto(this Videa.CuratedRateNS.Data.DataServices.CuratedRate source)
		{
			return new CuratedRate
			{
				CuratedRateId = source.CuratedRateId,
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToString(),
				RateHashKey = source.RateHashKey.ToString(),
				RateVersion = source.RateVersion,
				CuratedRateValue = source.CuratedRateValue.ToString(),
				IsDynamicRate = source.IsDynamicRate,
				RateTypeId = source.RateTypeId,
				CurationStatusId = source.CurationStatusId,
				CreatedBy = source.CreatedBy,
				ModifiedBy = source.ModifiedBy,
				RowVersion = source.RowVersion
			};

		}
		public  static RateType ToProto(this Videa.CuratedRateNS.Data.DataServices.RateType source)
		{
			return new RateType
			{
				RateTypeId = source.RateTypeId,
				RateTypeName = source.RateTypeName,
				RateTypeDescription = source.RateTypeDescription
			};

		}
		public  static CurationStatus ToProto(this Videa.CuratedRateNS.Data.DataServices.CurationStatus source)
		{
			return new CurationStatus
			{
				CurationStatusId = source.CurationStatusId,
				CurationStatusName = source.CurationStatusName,
				CurationStatusDescription = source.CurationStatusDescription
			};

		}
		public  static Rate ToProto(this Videa.CuratedRateNS.Data.DataServices.Rate source)
		{
			return new Rate
			{
				todo = source.todo
			};

		}
		#endregion Methods
	}
}
