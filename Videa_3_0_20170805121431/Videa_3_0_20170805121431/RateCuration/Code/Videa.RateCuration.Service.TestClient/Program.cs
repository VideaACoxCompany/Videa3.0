using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.RateCurationNS.Service.TestClient
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
			var client = new RateCurationService.RateCurationServiceClient(channel);
			TestCurateSellerRates(client);
			TestCuratePricingEngineRates(client);
			TestCurateSharebuilderRates(client);

		}
		public  static void TestCurateSellerRates(RateCurationService.RateCurationServiceClient client)
		{
			var request = new CurateSellerRatesRequest();
			var response = client.CurateSellerRates(request);

		}
		public  static void TestCuratePricingEngineRates(RateCurationService.RateCurationServiceClient client)
		{
			var request = new CuratePricingEngineRatesRequest();
			var response = client.CuratePricingEngineRates(request);

		}
		public  static void TestCurateSharebuilderRates(RateCurationService.RateCurationServiceClient client)
		{
			var request = new CurateSharebuilderRatesRequest();
			var response = client.CurateSharebuilderRates(request);

		}
		#endregion Methods
	}
}
