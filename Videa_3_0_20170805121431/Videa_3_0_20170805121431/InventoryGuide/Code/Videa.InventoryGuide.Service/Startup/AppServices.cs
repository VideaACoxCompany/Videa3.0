using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.InventoryGuideNS.Data.DataServices;

namespace Videa.InventoryGuideNS.Service
{
	public static class AppServices
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static IServiceCollection AddAppServices(this IServiceCollection serviceCollection)
		{
			 serviceCollection.AddTransient<IInventoryGuideDbProvider>(
                p => new InventoryGuideDbProvider("Server = localhost; Database = InventoryGuide; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
