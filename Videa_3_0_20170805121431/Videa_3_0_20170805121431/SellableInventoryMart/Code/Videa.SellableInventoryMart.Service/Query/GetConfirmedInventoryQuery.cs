using System;
using System.Collections.Generic;
using MediatR;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
{
	public class GetConfirmedInventoryQuery : IRequest<IList<SellableInventoryDto>>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.String StationList
		{
			get;
			set;
		} 
		public System.String RateCardTypeHashKey
		{
			get;
			set;
		} 
		public System.String RateCardDaypartList
		{
			get;
			set;
		} 
		public System.String SellingTitleList
		{
			get;
			set;
		} 
		public System.String BroadcastWeekList
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
