using System;
using System.Collections.Generic;

namespace Videa.InventoryGuideNS.Data.DataServices
{
	public abstract class BaseDataService
	{
		#region Fields
		protected  readonly  IInventoryGuideDbProvider DbProvider;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		protected BaseDataService(IInventoryGuideDbProvider dbProvider)
		{
			DbProvider = dbProvider ?? throw new ArgumentException(nameof(dbProvider));
		}
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
