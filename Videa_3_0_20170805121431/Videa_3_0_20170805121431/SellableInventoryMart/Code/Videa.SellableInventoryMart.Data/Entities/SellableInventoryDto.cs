using System;
using System.Collections.Generic;

namespace Videa.SellableInventoryMartNS.Data.DataServices
{
	public class SellableInventoryDto
	{
		#region Fields
		#endregion Fields
		#region Properties
		public DateTime SellingTitleStartDate
		{
			get;
			set;
		} 
		public DateTime SellingTitleEndDate
		{
			get;
			set;
		} 
		public String SellingTitleName
		{
			get;
			set;
		} 
		public String RateCardDaypartName
		{
			get;
			set;
		} 
		public String SellingTitleDaysOfWeekName
		{
			get;
			set;
		} 
		public String RateCardTypeName
		{
			get;
			set;
		} 
		public Char[] SellableInventoryHashKey
		{
			get;
			set;
		} 
		public Char[] StationHashKey
		{
			get;
			set;
		} 
		public Char[] SellingTitleDaysOfWeekHashKey
		{
			get;
			set;
		} 
		public Char[] RateCardTypeHashKey
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
