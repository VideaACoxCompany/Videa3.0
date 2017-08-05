using System;
using System.Collections.Generic;
using MediatR;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
{
	public class GetAvailMartQuery : IRequest<IList<AvailMart>>
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
		public System.String DaypartHashKey
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
