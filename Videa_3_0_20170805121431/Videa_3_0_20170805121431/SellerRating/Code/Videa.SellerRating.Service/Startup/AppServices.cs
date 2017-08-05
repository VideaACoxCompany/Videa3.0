using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Videa.SellerRatingNS.Data.DataServices;

namespace Videa.SellerRatingNS.Service
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
			 serviceCollection.AddTransient<ISellerRatingDbProvider>(
                p => new SellerRatingDbProvider("Server = localhost; Database = SellerRating; Trusted_Connection = True; "));
            return serviceCollection; 
		}
		#endregion Methods
	}
}
