using System;
using System.Collections.Generic;

namespace Videa.SellerRateNS.Data.DataServices
{
	public abstract class BaseDataService
	{
		#region Fields
		protected  readonly  ISellerRateDbProvider DbProvider;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		protected BaseDataService(ISellerRateDbProvider dbProvider)
		{
			DbProvider = dbProvider ?? throw new ArgumentException(nameof(dbProvider));
		}
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
