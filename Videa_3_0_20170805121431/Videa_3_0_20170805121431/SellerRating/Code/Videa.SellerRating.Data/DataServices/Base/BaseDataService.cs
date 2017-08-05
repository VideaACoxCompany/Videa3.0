using System;
using System.Collections.Generic;

namespace Videa.SellerRatingNS.Data.DataServices
{
	public abstract class BaseDataService
	{
		#region Fields
		protected  readonly  ISellerRatingDbProvider DbProvider;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		protected BaseDataService(ISellerRatingDbProvider dbProvider)
		{
			DbProvider = dbProvider ?? throw new ArgumentException(nameof(dbProvider));
		}
		#endregion Constructors
		#region Methods
		#endregion Methods
	}
}
