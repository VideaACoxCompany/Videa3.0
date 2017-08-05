using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.AvailMartNS.Data.DataServices;

namespace Videa.AvailMartNS.Service
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
			 serviceCollection.AddTransient<IAvailMartDbProvider>(
                p => new AvailMartDbProvider("Server = localhost; Database = AvailMart; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
