using System;
using System.Collections.Generic;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class BulkStoreQuery : IRequest<bool>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public List<SellingTitle> SellingTitle
		{
			get;
			set;
		} 
		public List<Station> Station
		{
			get;
			set;
		} 
		public List<StationGroup> StationGroup
		{
			get;
			set;
		} 
		public List<RateCard> RateCard
		{
			get;
			set;
		} 
		public List<RateCardDaypart> RateCardDaypart
		{
			get;
			set;
		} 
		public List<RateCardType> RateCardType
		{
			get;
			set;
		} 
		public List<SellingTitleTimeRange> SellingTitleTimeRange
		{
			get;
			set;
		} 
		public List<SellingTitleDaysOfWeek> SellingTitleDaysOfWeek
		{
			get;
			set;
		} 
		public List<RatePeriod> RatePeriod
		{
			get;
			set;
		} 
		public List<SellableInventory> SellableInventory
		{
			get;
			set;
		} 
		public List<SellableInventoryDto> SellableInventoryDto
		{
			get;
			set;
		} 
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
