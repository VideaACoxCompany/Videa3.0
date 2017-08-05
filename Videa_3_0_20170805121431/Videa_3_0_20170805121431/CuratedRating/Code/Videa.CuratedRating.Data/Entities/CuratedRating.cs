using System;
using System.Collections.Generic;

namespace Videa.CuratedRatingNS.Data.DataServices
{
	public class CuratedRating
	{
		#region Fields
		#endregion Fields
		#region Properties
		public Int64 CuratedRatingId
		{
			get;
			set;
		} 
		public Char[] SellableInventoryHashKey
		{
			get;
			set;
		} 
		public Char[] RatingHashKey
		{
			get;
			set;
		} 
		public Int32 RatingVersion
		{
			get;
			set;
		} 
		public Boolean IsDynamicRating
		{
			get;
			set;
		} 
		public Decimal CuratingRatingValue
		{
			get;
			set;
		} 
		public Int32 RatingTypeId
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
