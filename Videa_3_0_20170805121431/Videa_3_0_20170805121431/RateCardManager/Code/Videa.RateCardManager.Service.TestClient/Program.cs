using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.RateCardManagerNS.Service.TestClient
{
	public class Program
	{
		#region Fields
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		#endregion Constructors
		#region Methods
		public  static void Main(string [] args)
		{
			Console.WriteLine("Press any key once the service has started");
			Console.ReadKey();
			Channel channel = new Channel("127.0.0.1:50025", ChannelCredentials.Insecure); 
			var client = new RateCardManagerService.RateCardManagerServiceClient(channel);
			TestGetRateCard(client);

		}
		public  static void TestGetRateCard(RateCardManagerService.RateCardManagerServiceClient client)
		{
			var request = new GetRateCardRequest();
			var response = client.GetRateCard(request);

		}
		#endregion Methods
	}
}
