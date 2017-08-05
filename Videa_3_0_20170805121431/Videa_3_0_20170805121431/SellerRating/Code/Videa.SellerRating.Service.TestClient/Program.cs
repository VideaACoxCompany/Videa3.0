using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.SellerRatingNS.Service.TestClient
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
			var client = new SellerRatingService.SellerRatingServiceClient(channel);
			TestRatingDemoDelete(client);
			TestRatingPeriodDelete(client);
			TestSellableInventoryRatingDelete(client);
			TestRatingDemoAddUpdate(client);
			TestRatingPeriodAddUpdate(client);
			TestSellableInventoryRatingAddUpdate(client);
			TestGetSellerRatingsByInventoryKeys(client);
			TestGetSellerRatingsByRatingKeys(client);
			TestBulkStore(client);

		}
		public  static void TestRatingDemoDelete(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new RatingDemoDeleteRequest();
			request.RatingDemoHashKey = "d1cda77f-e677-4e9d-a086-a67ba1212b0c"; 
			var response = client.RatingDemoDelete(request);

		}
		public  static void TestRatingPeriodDelete(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new RatingPeriodDeleteRequest();
			request.RatingPeriodHashKey = "9074a3ba-7b60-420a-a816-7cf47a13add1"; 
			var response = client.RatingPeriodDelete(request);

		}
		public  static void TestSellableInventoryRatingDelete(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new SellableInventoryRatingDeleteRequest();
			request.SellableInventoryRatingHashKey = "57e6ab9c-7fb5-4354-ae52-70fac6d1dcc5"; 
			var response = client.SellableInventoryRatingDelete(request);

		}
		public  static void TestRatingDemoAddUpdate(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new RatingDemoAddUpdateRequest();
			request.RatingDemo = new RatingDemo();
			request.RatingDemo.RatingDemoHashKey = "dee667df-0d73-429b-b33c-ce36527c797a"; 
			request.RatingDemo.RatingDemoSqn = 178388896; 
			request.RatingDemo.RatingDemoName = "38a0617e-4150-40d0-9faa-954f0846c325"; 
			var response = client.RatingDemoAddUpdate(request);

		}
		public  static void TestRatingPeriodAddUpdate(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new RatingPeriodAddUpdateRequest();
			request.RatingPeriod = new RatingPeriod();
			request.RatingPeriod.RatingPeriodHashKey = "fdf207f4-5603-4dc3-8ea1-c54025ce7c6b"; 
			request.RatingPeriod.RatingPeriodSqn = 178388896; 
			request.RatingPeriod.RatingPeriodName = "9fef4120-3688-413c-b489-65788d000dd9"; 
			request.RatingPeriod.RatingPeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:17:17.0788364Z"), DateTimeKind.Utc)); 
			request.RatingPeriod.RatingPeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:17:17.0788364Z"), DateTimeKind.Utc)); 
			var response = client.RatingPeriodAddUpdate(request);

		}
		public  static void TestSellableInventoryRatingAddUpdate(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new SellableInventoryRatingAddUpdateRequest();
			request.SellableInventoryRating = new SellableInventoryRating();
			request.SellableInventoryRating.SellableInventoryRatingHashKey = "74fe8fc4-119a-41e5-8344-d46f48214d8a"; 
			request.SellableInventoryRating.SellableInventoryHashKey = "3aa26e82-ce30-4172-a077-8222792255f8"; 
			request.SellableInventoryRating.SellableInventoryRatingSqn = 178388896; 
			request.SellableInventoryRating.RatingDemoHashKey = "a01d5ebd-5fc8-4193-b89f-d5130ebe9df4"; 
			request.SellableInventoryRating.RatingPeriodHashKey = "e3afd6d1-1566-4a32-9703-94ab62291080"; 
			request.SellableInventoryRating.SellableInventoryRatingValue = "003e64c7-7664-4ff0-aeb9-3b42baee371e"; 
			request.SellableInventoryRating.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:17:17.0788364Z"), DateTimeKind.Utc)); 
			var response = client.SellableInventoryRatingAddUpdate(request);

		}
		public  static void TestGetSellerRatingsByInventoryKeys(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new GetSellerRatingsByInventoryKeysRequest();
			request.SellableInventoryList = "2e18d85f-d991-43c2-834e-9c507ac543f4"; 
			var response = client.GetSellerRatingsByInventoryKeys(request);

		}
		public  static void TestGetSellerRatingsByRatingKeys(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new GetSellerRatingsByRatingKeysRequest();
			request.SellableInventoryRatingList = "9e07e1f7-75f2-4ec2-953d-456d8f437cd5"; 
			var response = client.GetSellerRatingsByRatingKeys(request);

		}
		public  static void TestBulkStore(SellerRatingService.SellerRatingServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.RatingDemo = new RatingDemo();
			request.RatingDemo.RatingDemoHashKey = "4e350ea0-5b38-4ea2-b625-29cb4f305c9a"; 
			request.RatingDemo.RatingDemoSqn = 178388896; 
			request.RatingDemo.RatingDemoName = "28bdc0b9-1764-4abb-9d7e-1b68de42d33a"; 
			request.RatingPeriod = new RatingPeriod();
			request.RatingPeriod.RatingPeriodHashKey = "859a9ffe-c76d-4b06-b78b-301fc54d0d91"; 
			request.RatingPeriod.RatingPeriodSqn = 178388896; 
			request.RatingPeriod.RatingPeriodName = "ed31e45d-761a-434c-95a7-8407c5112278"; 
			request.RatingPeriod.RatingPeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:17:17.0788364Z"), DateTimeKind.Utc)); 
			request.RatingPeriod.RatingPeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:17:17.0788364Z"), DateTimeKind.Utc)); 
			request.SellableInventoryRating = new SellableInventoryRating();
			request.SellableInventoryRating.SellableInventoryRatingHashKey = "13fcc7eb-88d5-4af9-97f4-6a260305b978"; 
			request.SellableInventoryRating.SellableInventoryHashKey = "b344cc8d-19e9-4b87-8b5b-d697ed56da1b"; 
			request.SellableInventoryRating.SellableInventoryRatingSqn = 178388896; 
			request.SellableInventoryRating.RatingDemoHashKey = "92d3fbe7-14a0-42f3-94ba-210601717cc6"; 
			request.SellableInventoryRating.RatingPeriodHashKey = "74047427-8747-4cc4-bef5-f3c1a53d569e"; 
			request.SellableInventoryRating.SellableInventoryRatingValue = "cef90ee5-dd51-4bee-81bd-96dfc9104225"; 
			request.SellableInventoryRating.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:17:17.0788364Z"), DateTimeKind.Utc)); 
			request.Rating = new Rating();
			request.Rating.SellableInventoryRatingValue = "8feee500-6a8c-4e21-9f50-854fbf92ed0d"; 
			request.Rating.SellableInventoryHashKey = "741c0a90-f7af-420f-bcad-6777465429ab"; 
			request.Rating.SellableInventoryRatingHashKey = "31b38955-77e2-4559-9620-cf300aed5f2a"; 
			request.Rating.RatingDemoHashKey = "d5901192-f818-48db-8ceb-56c095c41656"; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
