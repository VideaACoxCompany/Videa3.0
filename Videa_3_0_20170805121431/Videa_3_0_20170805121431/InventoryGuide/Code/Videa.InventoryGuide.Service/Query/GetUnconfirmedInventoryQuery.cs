using System;
using System.Collections.Generic;
using MediatR;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public class GetUnconfirmedInventoryQuery : IRequest<IList<SellableInventoryDto>>
	{
		#region Fields
		#endregion Fields
		#region Properties
		public System.String StationHashKey
		{
			get;
			set;
		} 
		public System.String RateCardTypeHashKey
		{
			get;
			set;
		} 
		public System.String RateCardDaypartHashKey
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
