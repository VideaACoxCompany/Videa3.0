using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.SharebuilderRateNS.Service.TestClient
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
			var client = new SharebuilderRateService.SharebuilderRateServiceClient(channel);
			TestRateTierDelete(client);
			TestRatePeriodDelete(client);
			TestSellableInventoryRateDelete(client);
			TestRateTierAddUpdate(client);
			TestRatePeriodAddUpdate(client);
			TestSellableInventoryRateAddUpdate(client);
			TestGetSharebuilderRates(client);
			TestBulkStore(client);

		}
		public  static void TestRateTierDelete(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new RateTierDeleteRequest();
			request.RateTierHashKey = "f7571b64-c8f8-4ca5-92f7-df81caee327f"; 
			var response = client.RateTierDelete(request);

		}
		public  static void TestRatePeriodDelete(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new RatePeriodDeleteRequest();
			request.RatePeriodHashKey = "739e0f01-06a3-4270-bfc5-efdf539581fc"; 
			var response = client.RatePeriodDelete(request);

		}
		public  static void TestSellableInventoryRateDelete(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new SellableInventoryRateDeleteRequest();
			request.SellableInventoryRateHashKey = "3e171356-8f29-4d5f-90bd-214494f685d0"; 
			var response = client.SellableInventoryRateDelete(request);

		}
		public  static void TestRateTierAddUpdate(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new RateTierAddUpdateRequest();
			request.RateTier = new RateTier();
			request.RateTier.RateTierHashKey = "f4b5eef5-78e1-450b-af95-3b58c92052ef"; 
			request.RateTier.RateTierSqn = 489758482; 
			request.RateTier.RateTierName = "5d06ee86-e78c-4472-acae-615ae95e903e"; 
			var response = client.RateTierAddUpdate(request);

		}
		public  static void TestRatePeriodAddUpdate(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new RatePeriodAddUpdateRequest();
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "d30596af-6b95-4d5e-a2a6-9b62bccd4f8e"; 
			request.RatePeriod.RatePeriodSqn = 489758482; 
			request.RatePeriod.RatePeriodName = "e8f0a624-4167-446e-8ab3-e7ad82f73a9b"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:14:38.3028355Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:14:38.3028355Z"), DateTimeKind.Utc)); 
			var response = client.RatePeriodAddUpdate(request);

		}
		public  static void TestSellableInventoryRateAddUpdate(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new SellableInventoryRateAddUpdateRequest();
			request.SellableInventoryRate = new SellableInventoryRate();
			request.SellableInventoryRate.SellableInventoryRateHashKey = "082fbdd6-07cb-46fd-b353-3ec42c62f1c6"; 
			request.SellableInventoryRate.SellableInventoryHashKey = "9e1d6137-21cf-4769-a572-42841f0e070f"; 
			request.SellableInventoryRate.SellableInventoryRateSqn = 489758482; 
			request.SellableInventoryRate.RateTierHashKey = "214ad8bf-5613-467a-96a2-5984683db223"; 
			request.SellableInventoryRate.SellableInventoryRateValue = "7511edb8-2570-44e5-ab80-83c5373d01b5"; 
			request.SellableInventoryRate.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:14:38.3028355Z"), DateTimeKind.Utc)); 
			var response = client.SellableInventoryRateAddUpdate(request);

		}
		public  static void TestGetSharebuilderRates(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new GetSharebuilderRatesRequest();
			request.SellableInventoryList = "72e54494-483d-4022-a188-4f9bdf458986"; 
			var response = client.GetSharebuilderRates(request);

		}
		public  static void TestBulkStore(SharebuilderRateService.SharebuilderRateServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.RateTier = new RateTier();
			request.RateTier.RateTierHashKey = "cdaf8527-e289-43ab-9987-e923c587d372"; 
			request.RateTier.RateTierSqn = 489758482; 
			request.RateTier.RateTierName = "3308ec43-9984-490b-9dbc-90f7e6a21d80"; 
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "2e81a607-d212-41ad-a0aa-21741a256328"; 
			request.RatePeriod.RatePeriodSqn = 489758482; 
			request.RatePeriod.RatePeriodName = "45a34e72-e0d4-44c0-b53d-239c5257d515"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:14:38.3028355Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:14:38.3028355Z"), DateTimeKind.Utc)); 
			request.SellableInventoryRate = new SellableInventoryRate();
			request.SellableInventoryRate.SellableInventoryRateHashKey = "9b9a9ea3-80af-4099-89fd-878e2a385dbd"; 
			request.SellableInventoryRate.SellableInventoryHashKey = "66d451ad-8bbe-409b-ad65-ab37d75ed8d8"; 
			request.SellableInventoryRate.SellableInventoryRateSqn = 489758482; 
			request.SellableInventoryRate.RateTierHashKey = "e62cd59d-d198-455c-a99a-68f9552825f8"; 
			request.SellableInventoryRate.SellableInventoryRateValue = "403a672a-6940-4f02-b96c-8523f85e9ed8"; 
			request.SellableInventoryRate.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:14:38.3028355Z"), DateTimeKind.Utc)); 
			request.Rate = new Rate();
			request.Rate.todo = 489758482; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
