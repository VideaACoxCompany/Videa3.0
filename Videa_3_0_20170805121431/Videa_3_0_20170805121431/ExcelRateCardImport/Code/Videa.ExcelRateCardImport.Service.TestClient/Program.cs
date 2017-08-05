using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.ExcelRateCardImportNS.Service.TestClient
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
			var client = new ExcelRateCardImportService.ExcelRateCardImportServiceClient(channel);
			TestImportRateCard(client);

		}
		public  static void TestImportRateCard(ExcelRateCardImportService.ExcelRateCardImportServiceClient client)
		{
			var request = new ImportRateCardRequest();
			var response = client.ImportRateCard(request);

		}
		#endregion Methods
	}
}
