using System;
using System.Collections.Generic;

namespace Videa.SellableInventoryMartNS.Data.DataServices
{
	public abstract class BaseDataService
	{
		#region Fields
		protected  readonly  ISellableInventoryMartDbProvider DbProvider;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		protected BaseDataService(ISellableInventoryMartDbProvider dbProvider)
		{
			DbProvider = dbProvider ?? throw new ArgumentException(nameof(dbProvider));
		}
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
