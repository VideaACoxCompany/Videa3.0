using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.RateCardConfirmationNS.Service.TestClient
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
			var client = new RateCardConfirmationService.RateCardConfirmationServiceClient(channel);
			TestConfirmRateCard(client);

		}
		public  static void TestConfirmRateCard(RateCardConfirmationService.RateCardConfirmationServiceClient client)
		{
			var request = new ConfirmRateCardRequest();
			var response = client.ConfirmRateCard(request);

		}
		#endregion Methods
	}
}
