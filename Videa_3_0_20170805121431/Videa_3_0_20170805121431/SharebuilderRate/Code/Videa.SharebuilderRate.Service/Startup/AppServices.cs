using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.SharebuilderRateNS.Data.DataServices;

namespace Videa.SharebuilderRateNS.Service
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
			 serviceCollection.AddTransient<ISharebuilderRateDbProvider>(
                p => new SharebuilderRateDbProvider("Server = localhost; Database = SharebuilderRate; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
