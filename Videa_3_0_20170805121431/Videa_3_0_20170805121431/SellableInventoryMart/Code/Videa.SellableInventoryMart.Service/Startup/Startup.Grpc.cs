using System;
using System.Collections.Generic;
using System;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using Videa.SellableInventoryMartNS.Service.Proto.Types;

namespace Videa.SellableInventoryMartNS.Service
{
	public static class ServiceProviderExtensions
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static Server AddGrpcServices(this IServiceProvider provider)
		{
			  var server = new Server
            {
                Services =
                {
                    //Reflection used by some testers
                    SellableInventoryMartService.BindService(provider.GetRequiredService<SellableInventoryMartServiceImpl>())
                    //,
                    //ServerReflection.BindService(new )
                },
                Ports =
                {
                    new ServerPort("0.0.0.0", 50025, ServerCredentials.Insecure)
            }

            };

            return server;
		}
		#endregion Methods
	}
}
