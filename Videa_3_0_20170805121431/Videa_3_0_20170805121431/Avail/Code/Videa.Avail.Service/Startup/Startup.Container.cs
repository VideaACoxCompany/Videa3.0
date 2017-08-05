using System;
using System.Collections.Generic;
using System;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using MediatR;

namespace Videa.AvailNS.Service
{
	public static class ServiceCollectionExtensions
	{
		#region Fields
		private static   IContainer _container;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static IServiceProvider ConfigureContainer(this IServiceCollection services)
		{
			   _container = new Container();
            _container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs
                // also register MediatR specifics
                config.Scan(scanner =>
                {
                    scanner.AssembliesAndExecutablesFromApplicationBaseDirectory(a => a.FullName.StartsWith("Videa"));
                    scanner.AssemblyContainingType<IMediator>();
            scanner.WithDefaultConventions();
            scanner.ConnectImplementationsToTypesClosing(typeof(IRequestHandler<,>));
            scanner.ConnectImplementationsToTypesClosing(typeof(IAsyncRequestHandler<,>));
            scanner.ConnectImplementationsToTypesClosing(typeof(INotificationHandler<>));
            scanner.ConnectImplementationsToTypesClosing(typeof(IAsyncNotificationHandler<>));
        });

                config.For<SingleInstanceFactory>().Use<SingleInstanceFactory>(ctx => t => ctx.GetInstance(t));
                config.For<MultiInstanceFactory>().Use<MultiInstanceFactory>(ctx => t => ctx.GetAllInstances(t));

                // Populate the container using the service collection
                config.Populate(services);
            });

            return _container.GetInstance<IServiceProvider>();
        
		}
		#endregion Methods
	}
}
