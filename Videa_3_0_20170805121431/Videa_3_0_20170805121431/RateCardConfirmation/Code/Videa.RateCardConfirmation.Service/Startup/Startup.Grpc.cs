using System;
using System.Collections.Generic;
using System;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using Videa.RateCardConfirmation.Service.Proto.Types;

namespace Videa.RateCardConfirmationNS.Service
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
                    RateCardConfirmationService.BindService(provider.GetRequiredService<RateCardConfirmationServiceImpl>())
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
