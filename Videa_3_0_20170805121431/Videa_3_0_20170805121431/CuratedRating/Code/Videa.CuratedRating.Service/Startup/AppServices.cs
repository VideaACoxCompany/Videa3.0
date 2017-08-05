using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.CuratedRatingNS.Data.DataServices;

namespace Videa.CuratedRatingNS.Service
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
			 serviceCollection.AddTransient<ICuratedRatingDbProvider>(
                p => new CuratedRatingDbProvider("Server = localhost; Database = CuratedRating; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
