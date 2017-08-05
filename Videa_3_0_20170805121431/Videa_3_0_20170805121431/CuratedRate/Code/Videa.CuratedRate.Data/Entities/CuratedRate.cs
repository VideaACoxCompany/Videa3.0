using System;
using System.Collections.Generic;

namespace Videa.CuratedRateNS.Data.DataServices
{
	public class CuratedRate
	{
		#region Fields
		#endregion Fields
		#region Properties
		public Int64 CuratedRateId
		{
			get;
			set;
		} 
		public Char[] SellableInventoryHashKey
		{
			get;
			set;
		} 
		public Char[] RateHashKey
		{
			get;
			set;
		} 
		public Int32 RateVersion
		{
			get;
			set;
		} 
		public Decimal CuratedRateValue
		{
			get;
			set;
		} 
		public Boolean IsDynamicRate
		{
			get;
			set;
		} 
		public Int32 RateTypeId
		{
			get;
			set;
		} 
		public Int32 CurationStatusId
		{
			get;
			set;
		} 
		public String CreatedBy
		{
			get;
			set;
		} 
		public String ModifiedBy
		{
			get;
			set;
		} 
		public Byte[] RowVersion
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
