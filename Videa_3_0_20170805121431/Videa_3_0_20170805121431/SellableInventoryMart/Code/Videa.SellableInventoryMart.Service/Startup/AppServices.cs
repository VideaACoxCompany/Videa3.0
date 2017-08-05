using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.SellableInventoryMartNS.Data.DataServices;

namespace Videa.SellableInventoryMartNS.Service
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
			 serviceCollection.AddTransient<ISellableInventoryMartDbProvider>(
                p => new SellableInventoryMartDbProvider("Server = localhost; Database = SellableInventoryMart; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
