using System;
using System.Collections.Generic;
using Videa.CuratedRateNS.Service.Proto.Types;

namespace Videa.CuratedRateNS.Service
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
		public  static Videa.CuratedRateNS.Data.DataServices.CuratedRate ToEntity(this CuratedRate source)
		{
			return new Videa.CuratedRateNS.Data.DataServices.CuratedRate
			{
				CuratedRateId = source.CuratedRateId,
				SellableInventoryHashKey = source.SellableInventoryHashKey.ToCharArray(),
				RateHashKey = source.RateHashKey.ToCharArray(),
				RateVersion = source.RateVersion,
				CuratedRateValue = Decimal.Parse(source.CuratedRateValue),
				IsDynamicRate = source.IsDynamicRate,
				RateTypeId = source.RateTypeId,
				CurationStatusId = source.CurationStatusId,
				CreatedBy = source.CreatedBy,
				ModifiedBy = source.ModifiedBy,
				RowVersion = source.RowVersion
			};

		}
		public  static Videa.CuratedRateNS.Data.DataServices.RateType ToEntity(this RateType source)
		{
			return new Videa.CuratedRateNS.Data.DataServices.RateType
			{
				RateTypeId = source.RateTypeId,
				RateTypeName = source.RateTypeName,
				RateTypeDescription = source.RateTypeDescription
			};

		}
		public  static Videa.CuratedRateNS.Data.DataServices.CurationStatus ToEntity(this CurationStatus source)
		{
			return new Videa.CuratedRateNS.Data.DataServices.CurationStatus
			{
				CurationStatusId = source.CurationStatusId,
				CurationStatusName = source.CurationStatusName,
				CurationStatusDescription = source.CurationStatusDescription
			};

		}
		public  static Videa.CuratedRateNS.Data.DataServices.Rate ToEntity(this Rate source)
		{
			return new Videa.CuratedRateNS.Data.DataServices.Rate
			{
				todo = source.todo
			};

		}
		#endregion Methods
	}
}
