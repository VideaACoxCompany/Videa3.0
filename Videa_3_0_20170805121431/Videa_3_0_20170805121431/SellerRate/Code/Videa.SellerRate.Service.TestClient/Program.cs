using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.SellerRateNS.Service.TestClient
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
			var client = new SellerRateService.SellerRateServiceClient(channel);
			TestRateTierDelete(client);
			TestRatePeriodDelete(client);
			TestSellableInventoryRateDelete(client);
			TestRateTierAddUpdate(client);
			TestRatePeriodAddUpdate(client);
			TestSellableInventoryRateAddUpdate(client);
			TestGetSellerRatesByInventoryKeys(client);
			TestGetSellerRatesByRateKeys(client);
			TestBulkStore(client);

		}
		public  static void TestRateTierDelete(SellerRateService.SellerRateServiceClient client)
		{
			var request = new RateTierDeleteRequest();
			request.RateTierHashKey = "6bb39c87-0ca8-4cbb-8c8d-b5b139863321"; 
			var response = client.RateTierDelete(request);

		}
		public  static void TestRatePeriodDelete(SellerRateService.SellerRateServiceClient client)
		{
			var request = new RatePeriodDeleteRequest();
			request.RatePeriodHashKey = "f40578d7-60cd-46a5-a866-717e5ac44244"; 
			var response = client.RatePeriodDelete(request);

		}
		public  static void TestSellableInventoryRateDelete(SellerRateService.SellerRateServiceClient client)
		{
			var request = new SellableInventoryRateDeleteRequest();
			request.SellableInventoryRateHashKey = "755d2180-21e7-4b26-89ee-f09f4b31c38b"; 
			var response = client.SellableInventoryRateDelete(request);

		}
		public  static void TestRateTierAddUpdate(SellerRateService.SellerRateServiceClient client)
		{
			var request = new RateTierAddUpdateRequest();
			request.RateTier = new RateTier();
			request.RateTier.RateTierHashKey = "70e41189-2c6e-4165-9f64-01bb922ebc64"; 
			request.RateTier.RateTierSqn = 734656429; 
			request.RateTier.RateTierName = "e38ffd1c-c2c7-4d0c-bd32-8a3ea80c5a90"; 
			var response = client.RateTierAddUpdate(request);

		}
		public  static void TestRatePeriodAddUpdate(SellerRateService.SellerRateServiceClient client)
		{
			var request = new RatePeriodAddUpdateRequest();
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "7bb463f3-a8ff-4122-ba84-f821021e5216"; 
			request.RatePeriod.RatePeriodSqn = 734656429; 
			request.RatePeriod.RatePeriodName = "8b17d0e9-60e4-4feb-b72b-0f2f9536a8b9"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:16:37.1498399Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:16:37.1498399Z"), DateTimeKind.Utc)); 
			var response = client.RatePeriodAddUpdate(request);

		}
		public  static void TestSellableInventoryRateAddUpdate(SellerRateService.SellerRateServiceClient client)
		{
			var request = new SellableInventoryRateAddUpdateRequest();
			request.SellableInventoryRate = new SellableInventoryRate();
			request.SellableInventoryRate.SellableInventoryRateHashKey = "e889ef34-92f7-4fb5-bc42-003719f8c569"; 
			request.SellableInventoryRate.SellableInventoryHashKey = "fb29d07f-5973-4d9d-8c34-82e7f5b7bd11"; 
			request.SellableInventoryRate.SellableInventoryRateSqn = 734656429; 
			request.SellableInventoryRate.RateTierHashKey = "ef26af44-5060-4b54-8392-441166e1d3cf"; 
			request.SellableInventoryRate.RatePeriodHashKey = "5b59b155-1ba9-45cd-9c42-d6101af009f1"; 
			request.SellableInventoryRate.SellableInventoryRateValue = "a9952c6d-4e70-4d69-b139-e9a9ef6424e3"; 
			request.SellableInventoryRate.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:16:37.1498399Z"), DateTimeKind.Utc)); 
			var response = client.SellableInventoryRateAddUpdate(request);

		}
		public  static void TestGetSellerRatesByInventoryKeys(SellerRateService.SellerRateServiceClient client)
		{
			var request = new GetSellerRatesByInventoryKeysRequest();
			request.SellableInventoryList = "5c9ef38e-72dc-40ba-8b82-5fd0eeec6a3e"; 
			var response = client.GetSellerRatesByInventoryKeys(request);

		}
		public  static void TestGetSellerRatesByRateKeys(SellerRateService.SellerRateServiceClient client)
		{
			var request = new GetSellerRatesByRateKeysRequest();
			request.SellableInventoryRateList = "dcf53b73-e160-4e0f-8375-1610998f1e85"; 
			var response = client.GetSellerRatesByRateKeys(request);

		}
		public  static void TestBulkStore(SellerRateService.SellerRateServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.RateTier = new RateTier();
			request.RateTier.RateTierHashKey = "293e4c7e-e717-4e53-bdf5-cd64053e8245"; 
			request.RateTier.RateTierSqn = 734656429; 
			request.RateTier.RateTierName = "0381f4fb-ebd5-4a09-8545-2033bd8e1f65"; 
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "7fe04850-7798-479e-9d64-bd086473a2fd"; 
			request.RatePeriod.RatePeriodSqn = 734656429; 
			request.RatePeriod.RatePeriodName = "dbe627f4-353d-4240-836e-dbe53bca41f1"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:16:37.1498399Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:16:37.1498399Z"), DateTimeKind.Utc)); 
			request.SellableInventoryRate = new SellableInventoryRate();
			request.SellableInventoryRate.SellableInventoryRateHashKey = "2524165d-9432-4ff3-ab63-8229aa62e992"; 
			request.SellableInventoryRate.SellableInventoryHashKey = "b4846e7e-5e6c-473c-b08b-df43ef572441"; 
			request.SellableInventoryRate.SellableInventoryRateSqn = 734656429; 
			request.SellableInventoryRate.RateTierHashKey = "a6f5cb2d-146e-4bf3-a997-23544b34a186"; 
			request.SellableInventoryRate.RatePeriodHashKey = "1223ad54-fdaf-4d3f-b805-1c517ffb7d50"; 
			request.SellableInventoryRate.SellableInventoryRateValue = "0513d204-fbad-4135-9c56-e21130011522"; 
			request.SellableInventoryRate.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:16:37.1498399Z"), DateTimeKind.Utc)); 
			request.Rate = new Rate();
			request.Rate.SellableInventoryRateValue = "c0cc5c2b-216e-4a60-ba74-955eb28e02f7"; 
			request.Rate.SellableInventoryHashKey = "745391e6-6b7c-4871-a65f-876c6c0aac4c"; 
			request.Rate.SellableInventoryRateHashKey = "995d6e5f-b893-467a-ba73-5274cd29aeaa"; 
			request.Rate.RateTierHashKey = "a0c5e05b-0e55-4bf4-bafa-8aa6a1e2db18"; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
