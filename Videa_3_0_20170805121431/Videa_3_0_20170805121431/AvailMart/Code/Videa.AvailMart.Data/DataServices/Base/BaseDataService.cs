using System;
using System.Collections.Generic;

namespace Videa.AvailMartNS.Data.DataServices
{
	public abstract class BaseDataService
	{
		#region Fields
		protected  readonly  IAvailMartDbProvider DbProvider;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		protected BaseDataService(IAvailMartDbProvider dbProvider)
		{
			DbProvider = dbProvider ?? throw new ArgumentException(nameof(dbProvider));
		}
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
