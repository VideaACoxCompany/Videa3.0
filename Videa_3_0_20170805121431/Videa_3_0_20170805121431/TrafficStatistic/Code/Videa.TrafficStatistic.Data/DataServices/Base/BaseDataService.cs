using System;
using System.Collections.Generic;

namespace Videa.TrafficStatisticNS.Data.DataServices
{
	public abstract class BaseDataService
	{
		#region Fields
		protected  readonly  ITrafficStatisticDbProvider DbProvider;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		protected BaseDataService(ITrafficStatisticDbProvider dbProvider)
		{
			DbProvider = dbProvider ?? throw new ArgumentException(nameof(dbProvider));
		}
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
