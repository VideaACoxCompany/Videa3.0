using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.TrafficStatisticNS.Data.DataServices;

namespace Videa.TrafficStatisticNS.Service
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
			 serviceCollection.AddTransient<ITrafficStatisticDbProvider>(
                p => new TrafficStatisticDbProvider("Server = localhost; Database = TrafficStatistic; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
