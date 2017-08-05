using System;
using System.Collections.Generic;
using Videa.InventoryGuideNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.InventoryGuideNS.Service
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
		public  static List<Videa.InventoryGuideNS.Data.DataServices.SellingTitle> ToEntity(this RepeatedField<SellingTitle> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.Station> ToEntity(this RepeatedField<Station> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.StationGroup> ToEntity(this RepeatedField<StationGroup> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.RateCard> ToEntity(this RepeatedField<RateCard> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.RateCardDaypart> ToEntity(this RepeatedField<RateCardDaypart> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.RateCardType> ToEntity(this RepeatedField<RateCardType> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.SellingTitleTimeRange> ToEntity(this RepeatedField<SellingTitleTimeRange> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.SellingTitleDaysOfWeek> ToEntity(this RepeatedField<SellingTitleDaysOfWeek> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.RatePeriod> ToEntity(this RepeatedField<RatePeriod> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.SellableInventory> ToEntity(this RepeatedField<SellableInventory> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.InventoryGuideNS.Data.DataServices.SellableInventoryDto> ToEntity(this RepeatedField<SellableInventoryDto> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
