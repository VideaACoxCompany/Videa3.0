using System;
using System.Collections.Generic;
using System;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Videa.SellerRateNS.Service
{
	public class App
	{
		#region Fields
		private    IServiceProvider _serviceProvider;
		private    Server _server;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  void Start()
		{
			    _serviceProvider = new ServiceCollection().AddAppServices().ConfigureContainer();

            _server = _serviceProvider.AddGrpcServices();
            _server.Start();
		}
		public  void Stop()
		{
			throw new NotImplementedException();
		}
		#endregion Methods
	}
}
