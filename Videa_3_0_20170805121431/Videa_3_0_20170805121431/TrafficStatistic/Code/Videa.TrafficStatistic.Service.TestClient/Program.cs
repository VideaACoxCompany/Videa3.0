using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.TrafficStatisticNS.Service.TestClient
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
			var client = new TrafficStatisticService.TrafficStatisticServiceClient(channel);
			TestRatePeriodDelete(client);
			TestSellableInventoryTrafficStatisticsDelete(client);
			TestRatePeriodAddUpdate(client);
			TestSellableInventoryTrafficStatisticsAddUpdate(client);
			TestGetTrafficStatistics(client);
			TestBulkStore(client);

		}
		public  static void TestRatePeriodDelete(TrafficStatisticService.TrafficStatisticServiceClient client)
		{
			var request = new RatePeriodDeleteRequest();
			request.RatePeriodHashKey = "408a4be6-882b-4143-a3f9-fabcfa734d96"; 
			var response = client.RatePeriodDelete(request);

		}
		public  static void TestSellableInventoryTrafficStatisticsDelete(TrafficStatisticService.TrafficStatisticServiceClient client)
		{
			var request = new SellableInventoryTrafficStatisticsDeleteRequest();
			request.SellableInventoryTrafficStatisticHashKey = "20e65d09-1cd7-4437-b33d-016b057690e1"; 
			var response = client.SellableInventoryTrafficStatisticsDelete(request);

		}
		public  static void TestRatePeriodAddUpdate(TrafficStatisticService.TrafficStatisticServiceClient client)
		{
			var request = new RatePeriodAddUpdateRequest();
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "b13379df-9553-46bb-bf8e-9036e87f8c55"; 
			request.RatePeriod.RatePeriodSqn = 2118664305; 
			request.RatePeriod.RatePeriodName = "d273dee4-2cb3-43d9-a538-89ef64b11122"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:19.8998345Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:19.8998345Z"), DateTimeKind.Utc)); 
			var response = client.RatePeriodAddUpdate(request);

		}
		public  static void TestSellableInventoryTrafficStatisticsAddUpdate(TrafficStatisticService.TrafficStatisticServiceClient client)
		{
			var request = new SellableInventoryTrafficStatisticsAddUpdateRequest();
			request.SellableInventoryTrafficStatistics = new SellableInventoryTrafficStatistics();
			request.SellableInventoryTrafficStatistics.SellableInventoryTrafficStatisticHashKey = "8639d02f-807e-4ba5-bdd4-c7e406fc93c5"; 
			request.SellableInventoryTrafficStatistics.SellableInventoryHashKey = "9d39296d-a1d6-4e36-b081-d6a17ba43de6"; 
			request.SellableInventoryTrafficStatistics.SellableInventoryTrafficStatisticSqn = 2118664305; 
			request.SellableInventoryTrafficStatistics.SellableInventoryAURValue = "b572c35d-f469-4163-9cf0-aab15373c1bf"; 
			request.SellableInventoryTrafficStatistics.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:19.8998345Z"), DateTimeKind.Utc)); 
			var response = client.SellableInventoryTrafficStatisticsAddUpdate(request);

		}
		public  static void TestGetTrafficStatistics(TrafficStatisticService.TrafficStatisticServiceClient client)
		{
			var request = new GetTrafficStatisticsRequest();
			request.SellableInventoryList = "aeb6185e-2824-443d-9f22-238372c46898"; 
			var response = client.GetTrafficStatistics(request);

		}
		public  static void TestBulkStore(TrafficStatisticService.TrafficStatisticServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "9733af57-b1bd-4599-9fd2-a43c9e2da080"; 
			request.RatePeriod.RatePeriodSqn = 2118664305; 
			request.RatePeriod.RatePeriodName = "4057d645-054e-47e7-b7b1-1415298111e5"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:19.8998345Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:19.8998345Z"), DateTimeKind.Utc)); 
			request.SellableInventoryTrafficStatistics = new SellableInventoryTrafficStatistics();
			request.SellableInventoryTrafficStatistics.SellableInventoryTrafficStatisticHashKey = "410a69ea-b9ad-498e-9e09-46c9a0d92a53"; 
			request.SellableInventoryTrafficStatistics.SellableInventoryHashKey = "d63c53ce-a066-4661-884e-c435588b3284"; 
			request.SellableInventoryTrafficStatistics.SellableInventoryTrafficStatisticSqn = 2118664305; 
			request.SellableInventoryTrafficStatistics.SellableInventoryAURValue = "e035326c-667a-4c40-a9c3-82c892c54f3c"; 
			request.SellableInventoryTrafficStatistics.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:19.8998345Z"), DateTimeKind.Utc)); 
			request.TrafficStatistic = new TrafficStatistic();
			request.TrafficStatistic.todo = 2118664305; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
