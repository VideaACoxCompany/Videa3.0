using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.InventoryGuideNS.Service.TestClient
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
			var client = new InventoryGuideService.InventoryGuideServiceClient(channel);
			TestSellingTitleDelete(client);
			TestStationDelete(client);
			TestStationGroupDelete(client);
			TestRateCardDelete(client);
			TestRateCardDaypartDelete(client);
			TestRateCardTypeDelete(client);
			TestSellingTitleTimeRangeDelete(client);
			TestSellingTitleDaysOfWeekDelete(client);
			TestRatePeriodDelete(client);
			TestSellableInventoryDelete(client);
			TestSellingTitleAddUpdate(client);
			TestStationAddUpdate(client);
			TestStationGroupAddUpdate(client);
			TestRateCardAddUpdate(client);
			TestRateCardDaypartAddUpdate(client);
			TestRateCardTypeAddUpdate(client);
			TestSellingTitleTimeRangeAddUpdate(client);
			TestSellingTitleDaysOfWeekAddUpdate(client);
			TestRatePeriodAddUpdate(client);
			TestSellableInventoryAddUpdate(client);
			TestGetRateCardsByStation(client);
			TestGetRateCardsByDateRange(client);
			TestGetUnconfirmedInventory(client);
			TestBulkStore(client);

		}
		public  static void TestSellingTitleDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellingTitleDeleteRequest();
			request.SellingTitleHashKey = "146ce5f7-4859-42f3-8e09-489d26d60337"; 
			var response = client.SellingTitleDelete(request);

		}
		public  static void TestStationDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new StationDeleteRequest();
			request.StationHashKey = "f1a8c053-71a3-4e7d-ae5d-2d83c4318961"; 
			var response = client.StationDelete(request);

		}
		public  static void TestStationGroupDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new StationGroupDeleteRequest();
			request.StationGroupHashKey = "ebe30478-a73f-4e8a-97d3-033710dd8226"; 
			var response = client.StationGroupDelete(request);

		}
		public  static void TestRateCardDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RateCardDeleteRequest();
			request.RateCardHashKey = "1ab43ca5-3a73-4cc3-bf90-be8ffa758776"; 
			var response = client.RateCardDelete(request);

		}
		public  static void TestRateCardDaypartDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RateCardDaypartDeleteRequest();
			request.RateCardDaypartHashKey = "86a08cb7-f6d1-4053-88e9-e22c1844b2c2"; 
			var response = client.RateCardDaypartDelete(request);

		}
		public  static void TestRateCardTypeDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RateCardTypeDeleteRequest();
			request.RateCardTypeHashKey = "eaad0c4f-8ad7-4b3d-abc4-e74889261204"; 
			var response = client.RateCardTypeDelete(request);

		}
		public  static void TestSellingTitleTimeRangeDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellingTitleTimeRangeDeleteRequest();
			request.SellingTitleTimeRangeHashKey = "92839548-1570-4091-88e2-89ca45649438"; 
			var response = client.SellingTitleTimeRangeDelete(request);

		}
		public  static void TestSellingTitleDaysOfWeekDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellingTitleDaysOfWeekDeleteRequest();
			request.SellingTitleDaysOfWeekHashKey = "f0bb9ec9-8e5c-4d17-8ed5-238ee3730f67"; 
			var response = client.SellingTitleDaysOfWeekDelete(request);

		}
		public  static void TestRatePeriodDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RatePeriodDeleteRequest();
			request.RatePeriodHashKey = "f393ca8a-f417-4296-9d3a-f6c85e09d18f"; 
			var response = client.RatePeriodDelete(request);

		}
		public  static void TestSellableInventoryDelete(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellableInventoryDeleteRequest();
			request.SellableInventoryHashKey = "5c228c38-ec05-4aa8-98f2-af4bc9579f98"; 
			var response = client.SellableInventoryDelete(request);

		}
		public  static void TestSellingTitleAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellingTitleAddUpdateRequest();
			request.SellingTitle = new SellingTitle();
			request.SellingTitle.SellingTitleHashKey = "7c3407fa-36ac-46d4-b8bb-11f00cdc25e3"; 
			request.SellingTitle.SellingTitleSqn = 768529114; 
			request.SellingTitle.SellingTitleName = "eb9c5f84-c00b-4eb0-a313-b3ea978b6afd"; 
			request.SellingTitle.SellingTitleStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7218371Z"), DateTimeKind.Utc)); 
			request.SellingTitle.SellingTitleEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7218371Z"), DateTimeKind.Utc)); 
			var response = client.SellingTitleAddUpdate(request);

		}
		public  static void TestStationAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new StationAddUpdateRequest();
			request.Station = new Station();
			request.Station.StationHashKey = "02265c61-236d-4923-ac7d-1aed11c925f3"; 
			request.Station.StationSqn = 768529114; 
			request.Station.StationName = "6857cf1d-8596-4500-823c-cd24e0af2cec"; 
			request.Station.StationCallLetters = "357db459-f29a-4eec-a65e-6454e8d17bf4"; 
			var response = client.StationAddUpdate(request);

		}
		public  static void TestStationGroupAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new StationGroupAddUpdateRequest();
			request.StationGroup = new StationGroup();
			request.StationGroup.StationGroupHashKey = "b4e45201-93e3-410c-b603-c864fdae7d5a"; 
			request.StationGroup.StationGroupSqn = 768529114; 
			request.StationGroup.StationGroupName = "067330e3-0a7c-40cc-a542-cf83c807295e"; 
			var response = client.StationGroupAddUpdate(request);

		}
		public  static void TestRateCardAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RateCardAddUpdateRequest();
			request.RateCard = new RateCard();
			request.RateCard.RateCardHashKey = "b2ef4d63-99be-41e2-8c19-59548e81baeb"; 
			request.RateCard.RateCardSqn = 768529114; 
			request.RateCard.RateCardName = "e4c79405-9701-4d4a-b58f-7c87f670af6c"; 
			request.RateCard.RateCardStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7218371Z"), DateTimeKind.Utc)); 
			request.RateCard.RateCardEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7218371Z"), DateTimeKind.Utc)); 
			var response = client.RateCardAddUpdate(request);

		}
		public  static void TestRateCardDaypartAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RateCardDaypartAddUpdateRequest();
			request.RateCardDaypart = new RateCardDaypart();
			request.RateCardDaypart.RateCardDaypartHashKey = "7b6d75fe-ae7a-4ebf-9468-0b8c3723f46a"; 
			request.RateCardDaypart.RateCardDaypartSqn = 768529114; 
			request.RateCardDaypart.RateCardDaypartName = "b5d3b901-1c80-47af-a2bc-7fcbbc905c71"; 
			var response = client.RateCardDaypartAddUpdate(request);

		}
		public  static void TestRateCardTypeAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RateCardTypeAddUpdateRequest();
			request.RateCardType = new RateCardType();
			request.RateCardType.RateCardTypeHashKey = "3b5d81a5-88a1-4889-a995-5530e566fc06"; 
			request.RateCardType.RateCardTypeSqn = 768529114; 
			request.RateCardType.RateCardTypeName = "e9ea80ca-9833-46cb-8d48-e109d563c183"; 
			var response = client.RateCardTypeAddUpdate(request);

		}
		public  static void TestSellingTitleTimeRangeAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellingTitleTimeRangeAddUpdateRequest();
			request.SellingTitleTimeRange = new SellingTitleTimeRange();
			request.SellingTitleTimeRange.SellingTitleTimeRangeHashKey = "9a3291e6-5138-4574-b5e7-cf37d8fe5cb7"; 
			request.SellingTitleTimeRange.TimeRangeSqn = 768529114; 
			request.SellingTitleTimeRange.SellingTitleTimeRangeName = "d9217a52-5232-47c2-8c28-72f781339d20"; 
			var response = client.SellingTitleTimeRangeAddUpdate(request);

		}
		public  static void TestSellingTitleDaysOfWeekAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellingTitleDaysOfWeekAddUpdateRequest();
			request.SellingTitleDaysOfWeek = new SellingTitleDaysOfWeek();
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekHashKey = "8bd42dc8-2dad-46b8-9a25-9b90aa12a516"; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekSqn = 768529114; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekName = "0c9d00b6-26e7-4177-abac-c4b1a41460e3"; 
			request.SellingTitleDaysOfWeek.Mon = true; 
			request.SellingTitleDaysOfWeek.Tue = true; 
			request.SellingTitleDaysOfWeek.Wed = true; 
			request.SellingTitleDaysOfWeek.Thu = true; 
			request.SellingTitleDaysOfWeek.Fri = true; 
			request.SellingTitleDaysOfWeek.Sat = true; 
			request.SellingTitleDaysOfWeek.Sun = true; 
			var response = client.SellingTitleDaysOfWeekAddUpdate(request);

		}
		public  static void TestRatePeriodAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new RatePeriodAddUpdateRequest();
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "11376d4b-8162-4baf-9c36-301523e44a3b"; 
			request.RatePeriod.RatePeriodSqn = 768529114; 
			request.RatePeriod.RatePeriodName = "5a10fa9d-33f0-4197-a102-1a8ff226ec9a"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7218371Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7218371Z"), DateTimeKind.Utc)); 
			var response = client.RatePeriodAddUpdate(request);

		}
		public  static void TestSellableInventoryAddUpdate(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new SellableInventoryAddUpdateRequest();
			request.SellableInventory = new SellableInventory();
			request.SellableInventory.SellableInventoryHashKey = "95e034fa-5072-41f2-b540-57e37cc996e2"; 
			request.SellableInventory.SellableInventorySqn = 1539057042; 
			request.SellableInventory.StationHashKey = "6d967bcf-c0dd-4713-8b61-07f53018cdee"; 
			request.SellableInventory.StationGroupHashKey = "2d2815bb-b261-4d31-a0ce-9f66ea5ac472"; 
			request.SellableInventory.RateCardHashKey = "c05f6673-4921-497e-8aff-0130397bab9d"; 
			request.SellableInventory.RateCardDaypartHashKey = "f4972519-46e4-4539-8ebd-187e26a9c207"; 
			request.SellableInventory.RateCardTypeHashKey = "1e1ec97a-9437-47e2-8511-3f473bafa2e9"; 
			request.SellableInventory.SellingTitleHashKey = "07035202-c741-460f-a498-51b26b72e22f"; 
			request.SellableInventory.SellingTitleDaysOfWeekHashKey = "5f8527f0-87fb-49bb-b810-02b35611e867"; 
			request.SellableInventory.SellingTitleTimeRangeHashKey = "22885e8a-f0fd-443b-b339-5c0796c6cb6b"; 
			request.SellableInventory.RatePeriodHashKey = "470ea82a-1770-4a1b-8f39-14f8ee474616"; 
			var response = client.SellableInventoryAddUpdate(request);

		}
		public  static void TestGetRateCardsByStation(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new GetRateCardsByStationRequest();
			request.StationHashKey = "7fbf563b-56ca-4744-a4c7-045710f4be92"; 
			var response = client.GetRateCardsByStation(request);

		}
		public  static void TestGetRateCardsByDateRange(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new GetRateCardsByDateRangeRequest();
			request.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7271728Z"), DateTimeKind.Utc)); 
			request.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7271728Z"), DateTimeKind.Utc)); 
			var response = client.GetRateCardsByDateRange(request);

		}
		public  static void TestGetUnconfirmedInventory(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new GetUnconfirmedInventoryRequest();
			request.StationHashKey = "8dc503a2-58d4-4c57-b745-0dedad814f88"; 
			request.RateCardTypeHashKey = "6bafbe63-a074-43b4-a850-f216a2f947ed"; 
			request.RateCardDaypartHashKey = "19b1af03-f606-4030-ade0-dcc5e71f1fbb"; 
			request.BroadcastWeekList = "3f048fb9-e633-4ecc-af30-49b535c953c4"; 
			var response = client.GetUnconfirmedInventory(request);

		}
		public  static void TestBulkStore(InventoryGuideService.InventoryGuideServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.SellingTitle = new SellingTitle();
			request.SellingTitle.SellingTitleHashKey = "21aa5fcd-b9fa-4649-8125-485c4959554a"; 
			request.SellingTitle.SellingTitleSqn = 1539057042; 
			request.SellingTitle.SellingTitleName = "decfeb09-5bf5-4538-9b64-652547df2cde"; 
			request.SellingTitle.SellingTitleStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7271728Z"), DateTimeKind.Utc)); 
			request.SellingTitle.SellingTitleEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7271728Z"), DateTimeKind.Utc)); 
			request.Station = new Station();
			request.Station.StationHashKey = "f251a62e-7b6f-4175-a95c-ee88c657f1ff"; 
			request.Station.StationSqn = 1539057042; 
			request.Station.StationName = "ef5295d7-05b3-4e97-899c-f806f9c1c067"; 
			request.Station.StationCallLetters = "75b9dda6-602f-4324-b1c1-7b6e0b4971b3"; 
			request.StationGroup = new StationGroup();
			request.StationGroup.StationGroupHashKey = "1e4b0f6b-e6be-4f99-9813-97da1c1ccec6"; 
			request.StationGroup.StationGroupSqn = 1539057042; 
			request.StationGroup.StationGroupName = "82672ffe-191b-405e-88c1-24ee38ec7653"; 
			request.RateCard = new RateCard();
			request.RateCard.RateCardHashKey = "cb66711d-0e73-4ffc-bbb3-7df5ebfd1438"; 
			request.RateCard.RateCardSqn = 1539057042; 
			request.RateCard.RateCardName = "367ec503-34bb-48c6-ad2c-63b51bbb2b33"; 
			request.RateCard.RateCardStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7272393Z"), DateTimeKind.Utc)); 
			request.RateCard.RateCardEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7272393Z"), DateTimeKind.Utc)); 
			request.RateCardDaypart = new RateCardDaypart();
			request.RateCardDaypart.RateCardDaypartHashKey = "bedb57fb-d092-4fdc-8547-fdff77f436dd"; 
			request.RateCardDaypart.RateCardDaypartSqn = 1539057042; 
			request.RateCardDaypart.RateCardDaypartName = "b19e3e23-a2a8-498e-9536-8af36559a296"; 
			request.RateCardType = new RateCardType();
			request.RateCardType.RateCardTypeHashKey = "89977c66-0e5c-4c42-91dd-9da813fb1a27"; 
			request.RateCardType.RateCardTypeSqn = 1539057042; 
			request.RateCardType.RateCardTypeName = "c2d34504-351f-488e-925d-c57a85c4202b"; 
			request.SellingTitleTimeRange = new SellingTitleTimeRange();
			request.SellingTitleTimeRange.SellingTitleTimeRangeHashKey = "b001f576-ade5-4c14-8453-8e79f853ecb5"; 
			request.SellingTitleTimeRange.TimeRangeSqn = 1539057042; 
			request.SellingTitleTimeRange.SellingTitleTimeRangeName = "720c14da-f808-4b2c-ad70-6c0ae64e2167"; 
			request.SellingTitleDaysOfWeek = new SellingTitleDaysOfWeek();
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekHashKey = "be086a44-42fc-4086-9c1e-eb8f9d80da8f"; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekSqn = 1539057042; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekName = "db2bd678-3736-40dd-9beb-7f162cec0aa9"; 
			request.SellingTitleDaysOfWeek.Mon = true; 
			request.SellingTitleDaysOfWeek.Tue = true; 
			request.SellingTitleDaysOfWeek.Wed = true; 
			request.SellingTitleDaysOfWeek.Thu = true; 
			request.SellingTitleDaysOfWeek.Fri = true; 
			request.SellingTitleDaysOfWeek.Sat = true; 
			request.SellingTitleDaysOfWeek.Sun = true; 
			request.RatePeriod = new RatePeriod();
			request.RatePeriod.RatePeriodHashKey = "286fd236-ade0-4333-bc35-b5449a7dfe55"; 
			request.RatePeriod.RatePeriodSqn = 1539057042; 
			request.RatePeriod.RatePeriodName = "bb9cd264-a752-42b5-bb9e-2c5b6f10d31c"; 
			request.RatePeriod.RatePeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7272393Z"), DateTimeKind.Utc)); 
			request.RatePeriod.RatePeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:15:58.7272393Z"), DateTimeKind.Utc)); 
			request.SellableInventory = new SellableInventory();
			request.SellableInventory.SellableInventoryHashKey = "d2ca40ed-2547-4fcc-b935-5183202302cf"; 
			request.SellableInventory.SellableInventorySqn = 1539057042; 
			request.SellableInventory.StationHashKey = "afee9fe0-7581-4faa-80f3-7e9158af4cce"; 
			request.SellableInventory.StationGroupHashKey = "541cce5e-37be-49c6-a3c5-bd16607250df"; 
			request.SellableInventory.RateCardHashKey = "49bdd553-e20e-4d1d-b49f-88b6190d3694"; 
			request.SellableInventory.RateCardDaypartHashKey = "1586f1a1-b8d4-49aa-befb-d1726f70987b"; 
			request.SellableInventory.RateCardTypeHashKey = "e883e9e7-daf2-46f9-ae00-c9aa9b603c4e"; 
			request.SellableInventory.SellingTitleHashKey = "6b307faf-4728-4e60-9d97-237235c6b39e"; 
			request.SellableInventory.SellingTitleDaysOfWeekHashKey = "5fa63f80-aee9-4c33-beec-422e03fc6540"; 
			request.SellableInventory.SellingTitleTimeRangeHashKey = "00be94a8-28e5-4913-a84f-ebd30ec2476e"; 
			request.SellableInventory.RatePeriodHashKey = "a0475652-c995-4dcc-b6ca-9bfb39736ecd"; 
			request.SellableInventoryDto = new SellableInventoryDto();
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
