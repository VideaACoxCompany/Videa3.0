using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.AvailMartNS.Service.TestClient
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
			var client = new AvailMartService.AvailMartServiceClient(channel);
			TestAvailMartDelete(client);
			TestAvailListDelete(client);
			TestAvailLineWithDetailedPeriodsDelete(client);
			TestDetailedPeriodDelete(client);
			TestAvailMartAddUpdate(client);
			TestAvailListAddUpdate(client);
			TestAvailLineWithDetailedPeriodsAddUpdate(client);
			TestDetailedPeriodAddUpdate(client);
			TestGetAvailMart(client);
			TestBulkStore(client);

		}
		public  static void TestAvailMartDelete(AvailMartService.AvailMartServiceClient client)
		{
			var request = new AvailMartDeleteRequest();
			request.AvailMartHashKey = "f86f590e-3971-4dc2-ba0f-1951990bb829"; 
			var response = client.AvailMartDelete(request);

		}
		public  static void TestAvailListDelete(AvailMartService.AvailMartServiceClient client)
		{
			var request = new AvailListDeleteRequest();
			request.AvailListHashKey = "e046a9ce-6ea7-4c6e-ad41-b77199fb93f4"; 
			var response = client.AvailListDelete(request);

		}
		public  static void TestAvailLineWithDetailedPeriodsDelete(AvailMartService.AvailMartServiceClient client)
		{
			var request = new AvailLineWithDetailedPeriodsDeleteRequest();
			request.AvailLineWithDetailedPeriodsHashKey = "f743acef-ed1e-4301-a519-1342c6b880d0"; 
			var response = client.AvailLineWithDetailedPeriodsDelete(request);

		}
		public  static void TestDetailedPeriodDelete(AvailMartService.AvailMartServiceClient client)
		{
			var request = new DetailedPeriodDeleteRequest();
			request.DetailedPeriodHashKey = "587d621e-af06-44c8-88cf-83dbc07b7ffd"; 
			var response = client.DetailedPeriodDelete(request);

		}
		public  static void TestAvailMartAddUpdate(AvailMartService.AvailMartServiceClient client)
		{
			var request = new AvailMartAddUpdateRequest();
			request.AvailMart = new AvailMart();
			request.AvailMart.AvailMartHashKey = "7c2d015d-5c14-4e54-be47-f1a8517fa2c3"; 
			request.AvailMart.AvailMartSqn = 1106783771; 
			request.AvailMart.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.0766793Z"), DateTimeKind.Utc)); 
			request.AvailMart.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.0766793Z"), DateTimeKind.Utc)); 
			var response = client.AvailMartAddUpdate(request);

		}
		public  static void TestAvailListAddUpdate(AvailMartService.AvailMartServiceClient client)
		{
			var request = new AvailListAddUpdateRequest();
			request.AvailList = new AvailList();
			request.AvailList.AvailListHashKey = "0856c8ce-c0c7-44fc-b588-295a22f78104"; 
			request.AvailList.AvailListSqn = 1106783771; 
			request.AvailList.AvailMartHashKey = "1ac87b8c-4adb-4c72-b8ad-7c898f67b37c"; 
			request.AvailList.Name = "ec663657-d9ec-47ec-b2f6-37e5076eac17"; 
			request.AvailList.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.0766793Z"), DateTimeKind.Utc)); 
			request.AvailList.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.0766793Z"), DateTimeKind.Utc)); 
			var response = client.AvailListAddUpdate(request);

		}
		public  static void TestAvailLineWithDetailedPeriodsAddUpdate(AvailMartService.AvailMartServiceClient client)
		{
			var request = new AvailLineWithDetailedPeriodsAddUpdateRequest();
			request.AvailLineWithDetailedPeriods = new AvailLineWithDetailedPeriods();
			request.AvailLineWithDetailedPeriods.AvailLineWithDetailedPeriodsHashKey = "53864316-ac7d-4d7c-a8bf-199b20607c9e"; 
			request.AvailLineWithDetailedPeriods.AvailLineWithDetailedPeriodsSqn = 1106783771; 
			request.AvailLineWithDetailedPeriods.AvailListHashKey = "d0bb276b-4221-4f6e-80ce-6393af7c095e"; 
			request.AvailLineWithDetailedPeriods.DaypartName = "3d8d14ca-1741-44be-93c7-58570ea68a99"; 
			request.AvailLineWithDetailedPeriods.AvailName = "3e409de0-d901-4640-aa26-4494225de6cf"; 
			var response = client.AvailLineWithDetailedPeriodsAddUpdate(request);

		}
		public  static void TestDetailedPeriodAddUpdate(AvailMartService.AvailMartServiceClient client)
		{
			var request = new DetailedPeriodAddUpdateRequest();
			request.DetailedPeriod = new DetailedPeriod();
			request.DetailedPeriod.DetailedPeriodHashKey = "c9068cb7-1d04-42d0-97a3-fc66d15740bc"; 
			request.DetailedPeriod.DetailedPeriodSqn = 1106783771; 
			request.DetailedPeriod.AvailLineWithDetailedPeriodsHashKey = "a81f9454-ad55-4548-8b96-cb68b82166b1"; 
			request.DetailedPeriod.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.0766793Z"), DateTimeKind.Utc)); 
			request.DetailedPeriod.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.0766793Z"), DateTimeKind.Utc)); 
			request.DetailedPeriod.Rate = "da68928c-fe4f-4f0d-8228-1b3adcc20937"; 
			var response = client.DetailedPeriodAddUpdate(request);

		}
		public  static void TestGetAvailMart(AvailMartService.AvailMartServiceClient client)
		{
			var request = new GetAvailMartRequest();
			request.StationHashKey = "2bdcab64-3ee9-4a59-9412-3be774ca59dd"; 
			request.RateCardTypeHashKey = "2c4c1db2-671d-4beb-8ce9-feebbf740083"; 
			request.DaypartHashKey = "6548392d-a1ea-4c90-b61e-37189316aeda"; 
			request.BroadcastWeekList = "3e852bbc-cef1-43fe-aef4-8a558ac56c08"; 
			var response = client.GetAvailMart(request);

		}
		public  static void TestBulkStore(AvailMartService.AvailMartServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.AvailMart = new AvailMart();
			request.AvailMart.AvailMartHashKey = "b0892ecb-1e90-48c8-84fa-317cef82048e"; 
			request.AvailMart.AvailMartSqn = 500355980; 
			request.AvailMart.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.1146756Z"), DateTimeKind.Utc)); 
			request.AvailMart.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.1146756Z"), DateTimeKind.Utc)); 
			request.AvailList = new AvailList();
			request.AvailList.AvailListHashKey = "035ec7e3-950c-498e-8793-e2d4fbcecda5"; 
			request.AvailList.AvailListSqn = 500355980; 
			request.AvailList.AvailMartHashKey = "4bea46ce-e923-4b96-929f-09e3b1837308"; 
			request.AvailList.Name = "be5537e0-bdf0-4c71-8aba-39ecb6ada267"; 
			request.AvailList.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.1146756Z"), DateTimeKind.Utc)); 
			request.AvailList.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.1146756Z"), DateTimeKind.Utc)); 
			request.AvailLineWithDetailedPeriods = new AvailLineWithDetailedPeriods();
			request.AvailLineWithDetailedPeriods.AvailLineWithDetailedPeriodsHashKey = "024a7571-60e7-4f08-93dd-4114ea2ade47"; 
			request.AvailLineWithDetailedPeriods.AvailLineWithDetailedPeriodsSqn = 500355980; 
			request.AvailLineWithDetailedPeriods.AvailListHashKey = "ebe038a4-914d-480e-8443-364f4bf71315"; 
			request.AvailLineWithDetailedPeriods.DaypartName = "43a2069f-9025-4094-8b90-16f48bab87e0"; 
			request.AvailLineWithDetailedPeriods.AvailName = "939ad4b9-a6a7-4828-87dc-ba385e50f8d2"; 
			request.DetailedPeriod = new DetailedPeriod();
			request.DetailedPeriod.DetailedPeriodHashKey = "0d2f5467-67e2-445a-8063-88bf8e501b34"; 
			request.DetailedPeriod.DetailedPeriodSqn = 500355980; 
			request.DetailedPeriod.AvailLineWithDetailedPeriodsHashKey = "e70cf0e8-ca46-4ab3-a56a-8cc836aa2b66"; 
			request.DetailedPeriod.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.1146756Z"), DateTimeKind.Utc)); 
			request.DetailedPeriod.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:21:39.1146756Z"), DateTimeKind.Utc)); 
			request.DetailedPeriod.Rate = "3899a128-381f-4f3b-9909-5f80a74f023a"; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
