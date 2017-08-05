using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.CuratedRateNS.Data.DataServices;

namespace Videa.CuratedRateNS.Service
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
			 serviceCollection.AddTransient<ICuratedRateDbProvider>(
                p => new CuratedRateDbProvider("Server = localhost; Database = CuratedRate; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
