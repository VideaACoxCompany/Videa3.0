using System;
using System.Collections.Generic;
using Videa.SellableInventoryMartNS.Service.Proto.Types;
using System.Linq;
using Google.Protobuf.Collections;

namespace Videa.SellableInventoryMartNS.Service
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
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.SellingTitle> ToEntity(this RepeatedField<SellingTitle> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.Station> ToEntity(this RepeatedField<Station> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.StationGroup> ToEntity(this RepeatedField<StationGroup> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.RateCard> ToEntity(this RepeatedField<RateCard> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.RateCardDaypart> ToEntity(this RepeatedField<RateCardDaypart> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.RateCardType> ToEntity(this RepeatedField<RateCardType> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleTimeRange> ToEntity(this RepeatedField<SellingTitleTimeRange> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.SellingTitleDaysOfWeek> ToEntity(this RepeatedField<SellingTitleDaysOfWeek> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryPeriod> ToEntity(this RepeatedField<SellableInventoryPeriod> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.SellableInventory> ToEntity(this RepeatedField<SellableInventory> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		public  static List<Videa.SellableInventoryMartNS.Data.DataServices.SellableInventoryDto> ToEntity(this RepeatedField<SellableInventoryDto> source)
		{
			return source.Select(s => s.ToEntity()).ToList();

		}
		#endregion Methods
	}
}
