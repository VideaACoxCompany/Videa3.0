using System;
using System.Collections.Generic;

namespace Videa.SharebuilderRateNS.Data.DataServices
{
	public abstract class BaseDataService
	{
		#region Fields
		protected  readonly  ISharebuilderRateDbProvider DbProvider;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		protected BaseDataService(ISharebuilderRateDbProvider dbProvider)
		{
			DbProvider = dbProvider ?? throw new ArgumentException(nameof(dbProvider));
		}
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
