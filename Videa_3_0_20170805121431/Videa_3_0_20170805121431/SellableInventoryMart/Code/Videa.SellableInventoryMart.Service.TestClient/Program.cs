using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.SellableInventoryMartNS.Service.TestClient
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
			var client = new SellableInventoryMartService.SellableInventoryMartServiceClient(channel);
			TestSellingTitleDelete(client);
			TestStationDelete(client);
			TestStationGroupDelete(client);
			TestRateCardDelete(client);
			TestRateCardDaypartDelete(client);
			TestRateCardTypeDelete(client);
			TestSellingTitleTimeRangeDelete(client);
			TestSellingTitleDaysOfWeekDelete(client);
			TestSellableInventoryPeriodDelete(client);
			TestSellableInventoryDelete(client);
			TestSellingTitleAddUpdate(client);
			TestStationAddUpdate(client);
			TestStationGroupAddUpdate(client);
			TestRateCardAddUpdate(client);
			TestRateCardDaypartAddUpdate(client);
			TestRateCardTypeAddUpdate(client);
			TestSellingTitleTimeRangeAddUpdate(client);
			TestSellingTitleDaysOfWeekAddUpdate(client);
			TestSellableInventoryPeriodAddUpdate(client);
			TestSellableInventoryAddUpdate(client);
			TestGetRateCardsByStation(client);
			TestGetRateCardsByDateRange(client);
			TestGetConfirmedInventory(client);
			TestBulkStore(client);

		}
		public  static void TestSellingTitleDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellingTitleDeleteRequest();
			request.SellingTitleHashKey = "fa2296e0-d216-4962-ae9f-cc5e9b2b97d9"; 
			var response = client.SellingTitleDelete(request);

		}
		public  static void TestStationDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new StationDeleteRequest();
			request.StationHashKey = "449426d3-fc75-4caa-a19a-8983f6207ed3"; 
			var response = client.StationDelete(request);

		}
		public  static void TestStationGroupDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new StationGroupDeleteRequest();
			request.StationGroupHashKey = "7525bb99-2947-42c5-8e53-48010fa89efa"; 
			var response = client.StationGroupDelete(request);

		}
		public  static void TestRateCardDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new RateCardDeleteRequest();
			request.RateCardHashKey = "b4d69de0-6b57-44e5-ac2f-1d6db66fea83"; 
			var response = client.RateCardDelete(request);

		}
		public  static void TestRateCardDaypartDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new RateCardDaypartDeleteRequest();
			request.RateCardDaypartHashKey = "f092a58b-7304-456a-a5d4-61297c467de5"; 
			var response = client.RateCardDaypartDelete(request);

		}
		public  static void TestRateCardTypeDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new RateCardTypeDeleteRequest();
			request.RateCardTypeHashKey = "52fb96d5-7bfc-44ca-84a9-8ad93e201b4c"; 
			var response = client.RateCardTypeDelete(request);

		}
		public  static void TestSellingTitleTimeRangeDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellingTitleTimeRangeDeleteRequest();
			request.SellingTitleTimeRangeHashKey = "f2c71279-5016-4cd7-a94d-a01cfd563537"; 
			var response = client.SellingTitleTimeRangeDelete(request);

		}
		public  static void TestSellingTitleDaysOfWeekDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellingTitleDaysOfWeekDeleteRequest();
			request.SellingTitleDaysOfWeekHashKey = "6f340454-4a7e-425a-8264-63902988608f"; 
			var response = client.SellingTitleDaysOfWeekDelete(request);

		}
		public  static void TestSellableInventoryPeriodDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellableInventoryPeriodDeleteRequest();
			request.SellableInventoryPeriodHashKey = "f0b8d493-2c4c-4ded-a134-7ca04d4cf007"; 
			var response = client.SellableInventoryPeriodDelete(request);

		}
		public  static void TestSellableInventoryDelete(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellableInventoryDeleteRequest();
			request.SellableInventoryHashKey = "2dedf0fd-3552-48ad-aace-0f1d5365b984"; 
			var response = client.SellableInventoryDelete(request);

		}
		public  static void TestSellingTitleAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellingTitleAddUpdateRequest();
			request.SellingTitle = new SellingTitle();
			request.SellingTitle.SellingTitleHashKey = "874acd3b-eb06-4fe4-afa0-0f5c85af68fa"; 
			request.SellingTitle.SellingTitleSqn = 1037389668; 
			request.SellingTitle.SellingTitleName = "a99902d5-3e64-487a-a8d2-2d8bc76dea79"; 
			request.SellingTitle.SellingTitleStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.SellingTitle.SellingTitleEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			var response = client.SellingTitleAddUpdate(request);

		}
		public  static void TestStationAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new StationAddUpdateRequest();
			request.Station = new Station();
			request.Station.StationHashKey = "c4bfe4f5-f0cb-465a-a2d4-da70e228f639"; 
			request.Station.StationSqn = 1037389668; 
			request.Station.StationName = "6e5646da-9606-4ac3-8057-1dde2ed615d8"; 
			request.Station.StationCallLetters = "323f3036-d947-49c7-963c-52ab29b862fb"; 
			var response = client.StationAddUpdate(request);

		}
		public  static void TestStationGroupAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new StationGroupAddUpdateRequest();
			request.StationGroup = new StationGroup();
			request.StationGroup.StationGroupHashKey = "54e19337-6052-4d30-8fef-8754e1dc9532"; 
			request.StationGroup.StationGroupSqn = 1037389668; 
			request.StationGroup.StationGroupName = "cee4a3e1-d038-47b5-a3c5-cb1bd165d7ec"; 
			var response = client.StationGroupAddUpdate(request);

		}
		public  static void TestRateCardAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new RateCardAddUpdateRequest();
			request.RateCard = new RateCard();
			request.RateCard.RateCardHashKey = "cb405856-c155-408f-a6bb-7de48e615e10"; 
			request.RateCard.RateCardSqn = 1037389668; 
			request.RateCard.RateCardName = "9f7699af-6ee1-44a7-8377-745f09c60fe0"; 
			request.RateCard.RateCardStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.RateCard.RateCardEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			var response = client.RateCardAddUpdate(request);

		}
		public  static void TestRateCardDaypartAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new RateCardDaypartAddUpdateRequest();
			request.RateCardDaypart = new RateCardDaypart();
			request.RateCardDaypart.RateCardDaypartHashKey = "763a6126-31ff-41b1-a08d-fea471e670cd"; 
			request.RateCardDaypart.RateCardDaypartSqn = 1037389668; 
			request.RateCardDaypart.RateCardDaypartName = "ff769285-644c-4380-8dba-7d314130508e"; 
			var response = client.RateCardDaypartAddUpdate(request);

		}
		public  static void TestRateCardTypeAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new RateCardTypeAddUpdateRequest();
			request.RateCardType = new RateCardType();
			request.RateCardType.RateCardTypeHashKey = "13ab654a-714d-4d3c-9881-7a05615ac68e"; 
			request.RateCardType.RateCardTypeSqn = 1037389668; 
			request.RateCardType.RateCardTypeName = "98ad9e98-e18f-4f2d-ae70-79cf53608013"; 
			var response = client.RateCardTypeAddUpdate(request);

		}
		public  static void TestSellingTitleTimeRangeAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellingTitleTimeRangeAddUpdateRequest();
			request.SellingTitleTimeRange = new SellingTitleTimeRange();
			request.SellingTitleTimeRange.SellingTitleTimeRangeHashKey = "eb2e582c-d6db-4ad1-a4fe-7788997db26e"; 
			request.SellingTitleTimeRange.TimeRangeSqn = 1037389668; 
			request.SellingTitleTimeRange.SellingTitleTimeRangeName = "36de31ec-a76f-46cb-b0f1-688f567c280c"; 
			var response = client.SellingTitleTimeRangeAddUpdate(request);

		}
		public  static void TestSellingTitleDaysOfWeekAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellingTitleDaysOfWeekAddUpdateRequest();
			request.SellingTitleDaysOfWeek = new SellingTitleDaysOfWeek();
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekHashKey = "b89ce083-5133-461a-b275-f9e834b0b8d9"; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekSqn = 1037389668; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekName = "f254f888-d0ca-4381-8602-ca0680ac9fbd"; 
			request.SellingTitleDaysOfWeek.Mon = true; 
			request.SellingTitleDaysOfWeek.Tue = true; 
			request.SellingTitleDaysOfWeek.Wed = true; 
			request.SellingTitleDaysOfWeek.Thu = true; 
			request.SellingTitleDaysOfWeek.Fri = true; 
			request.SellingTitleDaysOfWeek.Sat = true; 
			request.SellingTitleDaysOfWeek.Sun = true; 
			var response = client.SellingTitleDaysOfWeekAddUpdate(request);

		}
		public  static void TestSellableInventoryPeriodAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellableInventoryPeriodAddUpdateRequest();
			request.SellableInventoryPeriod = new SellableInventoryPeriod();
			request.SellableInventoryPeriod.SellableInventoryPeriodHashKey = "0ec4c047-2a94-403d-9322-eba9a378ca62"; 
			request.SellableInventoryPeriod.SellableInventoryPeriodSqn = 1037389668; 
			request.SellableInventoryPeriod.SellableInventoryPeriodName = "d9e9b0c7-efed-4060-a0d5-fc3ba92c39c6"; 
			request.SellableInventoryPeriod.SellableInventoryPeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.SellableInventoryPeriod.SellableInventoryPeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			var response = client.SellableInventoryPeriodAddUpdate(request);

		}
		public  static void TestSellableInventoryAddUpdate(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new SellableInventoryAddUpdateRequest();
			request.SellableInventory = new SellableInventory();
			request.SellableInventory.SellableInventoryHashKey = "7fae2e9c-f729-4fac-afe3-4f84b65e4169"; 
			request.SellableInventory.SellableInventorySqn = 1037389668; 
			request.SellableInventory.StationHashKey = "00ad11e4-1120-4e71-ac55-1fe5204a195f"; 
			request.SellableInventory.StationGroupHashKey = "6278b830-823f-407f-9925-75e9956a2945"; 
			request.SellableInventory.RateCardHashKey = "6413979e-6cbc-4d63-a5ac-20e085681060"; 
			request.SellableInventory.RateCardDaypartHashKey = "5b86e090-f207-43e5-ab40-402d78287ff6"; 
			request.SellableInventory.RateCardTypeHashKey = "688e9478-f1c3-4a1c-950c-fc8e96efd39d"; 
			request.SellableInventory.SellingTitleHashKey = "ad0f7c97-4000-4987-876b-15075f691a16"; 
			request.SellableInventory.SellingTitleDaysOfWeekHashKey = "aba4e57a-eafa-4f1c-9a9c-9a1a5c89407b"; 
			request.SellableInventory.SellingTitleTimeRangeHashKey = "6a706f3e-4541-432b-add5-47c7a4e9e9b1"; 
			request.SellableInventory.SellableInventoryPeriodHashKey = "cb6fd085-10d4-4207-8799-cf029cc137b7"; 
			var response = client.SellableInventoryAddUpdate(request);

		}
		public  static void TestGetRateCardsByStation(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new GetRateCardsByStationRequest();
			request.StationHashKey = "25347620-1832-4ef9-84bf-1ac96adb3627"; 
			var response = client.GetRateCardsByStation(request);

		}
		public  static void TestGetRateCardsByDateRange(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new GetRateCardsByDateRangeRequest();
			request.StartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.EndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			var response = client.GetRateCardsByDateRange(request);

		}
		public  static void TestGetConfirmedInventory(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new GetConfirmedInventoryRequest();
			request.StationList = "057a1040-2ea3-4665-adb5-4d3233adfad8"; 
			request.RateCardTypeHashKey = "e0c2a0c5-29d3-4c9d-ab37-d7d7175893ff"; 
			request.RateCardDaypartList = "fe2fdfe3-988d-4b28-b753-5f5efafc9312"; 
			request.SellingTitleList = "a6eb600e-a353-457f-b455-c0ce8a3389cd"; 
			request.BroadcastWeekList = "7f8f2ced-3be8-49db-8c7c-50064fbdb586"; 
			var response = client.GetConfirmedInventory(request);

		}
		public  static void TestBulkStore(SellableInventoryMartService.SellableInventoryMartServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.SellingTitle = new SellingTitle();
			request.SellingTitle.SellingTitleHashKey = "ac0b1083-e632-4678-aa01-13ca0b79f8b5"; 
			request.SellingTitle.SellingTitleSqn = 1037389668; 
			request.SellingTitle.SellingTitleName = "a0f52e1a-ef9f-4269-8d55-1ec58cb688bf"; 
			request.SellingTitle.SellingTitleStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.SellingTitle.SellingTitleEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.Station = new Station();
			request.Station.StationHashKey = "c89f11ba-315f-4a89-bcb3-036e2659429e"; 
			request.Station.StationSqn = 1037389668; 
			request.Station.StationName = "53bd4ca2-a0c5-4e29-a034-781944efc2af"; 
			request.Station.StationCallLetters = "e20099e9-dd34-4bda-8eb5-ca14769bfa41"; 
			request.StationGroup = new StationGroup();
			request.StationGroup.StationGroupHashKey = "8ffe0eb6-3e36-4f20-bed1-1949424c141c"; 
			request.StationGroup.StationGroupSqn = 1037389668; 
			request.StationGroup.StationGroupName = "58e6769d-92ba-4274-a6e4-6880b40e84c3"; 
			request.RateCard = new RateCard();
			request.RateCard.RateCardHashKey = "4e8edf06-5218-4e70-aae7-a9e59f17f55c"; 
			request.RateCard.RateCardSqn = 1037389668; 
			request.RateCard.RateCardName = "6fbbe318-96bc-46a7-aaa7-40ac7695b023"; 
			request.RateCard.RateCardStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.RateCard.RateCardEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.RateCardDaypart = new RateCardDaypart();
			request.RateCardDaypart.RateCardDaypartHashKey = "e4ccbad7-ac0f-4041-8240-be43668da333"; 
			request.RateCardDaypart.RateCardDaypartSqn = 1037389668; 
			request.RateCardDaypart.RateCardDaypartName = "34a809ba-feac-4075-ba60-1941a200fb07"; 
			request.RateCardType = new RateCardType();
			request.RateCardType.RateCardTypeHashKey = "b26ec701-1b21-4fb9-ae59-5a224985bf6a"; 
			request.RateCardType.RateCardTypeSqn = 1037389668; 
			request.RateCardType.RateCardTypeName = "697967db-7917-4518-a74a-0ac9c381e106"; 
			request.SellingTitleTimeRange = new SellingTitleTimeRange();
			request.SellingTitleTimeRange.SellingTitleTimeRangeHashKey = "3148cade-12da-48bb-a1e3-3933ccb75e47"; 
			request.SellingTitleTimeRange.TimeRangeSqn = 1037389668; 
			request.SellingTitleTimeRange.SellingTitleTimeRangeName = "6b19caa6-4939-415d-90bf-b3917ba3b873"; 
			request.SellingTitleDaysOfWeek = new SellingTitleDaysOfWeek();
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekHashKey = "2f60852f-dee1-437d-be4c-a4dee856df11"; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekSqn = 1037389668; 
			request.SellingTitleDaysOfWeek.SellingTitleDaysOfWeekName = "1f3be942-3001-491b-86d0-5c14c7c4881b"; 
			request.SellingTitleDaysOfWeek.Mon = true; 
			request.SellingTitleDaysOfWeek.Tue = true; 
			request.SellingTitleDaysOfWeek.Wed = true; 
			request.SellingTitleDaysOfWeek.Thu = true; 
			request.SellingTitleDaysOfWeek.Fri = true; 
			request.SellingTitleDaysOfWeek.Sat = true; 
			request.SellingTitleDaysOfWeek.Sun = true; 
			request.SellableInventoryPeriod = new SellableInventoryPeriod();
			request.SellableInventoryPeriod.SellableInventoryPeriodHashKey = "f80de5bf-cc7a-4110-8652-03e4a04b5a09"; 
			request.SellableInventoryPeriod.SellableInventoryPeriodSqn = 1037389668; 
			request.SellableInventoryPeriod.SellableInventoryPeriodName = "89e4afa9-a0c0-49d7-a553-440eeb07f564"; 
			request.SellableInventoryPeriod.SellableInventoryPeriodStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.SellableInventoryPeriod.SellableInventoryPeriodEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.SellableInventory = new SellableInventory();
			request.SellableInventory.SellableInventoryHashKey = "6a2ca1bb-d4d6-4aa6-b5a8-c9cd4c366328"; 
			request.SellableInventory.SellableInventorySqn = 1037389668; 
			request.SellableInventory.StationHashKey = "0b15f49c-7ad9-489c-9cbb-bf2f4222bcab"; 
			request.SellableInventory.StationGroupHashKey = "451b3034-ca05-4f6e-8843-2918d322f1f0"; 
			request.SellableInventory.RateCardHashKey = "4fa006c9-655c-4bfa-97cc-a17d875a887c"; 
			request.SellableInventory.RateCardDaypartHashKey = "7ba8b574-cd99-47c6-aa1d-bd727995a842"; 
			request.SellableInventory.RateCardTypeHashKey = "a9045e94-76a4-42a4-973b-2e9b8dd264c8"; 
			request.SellableInventory.SellingTitleHashKey = "0129d093-5509-4a9e-8204-20f41add6c2c"; 
			request.SellableInventory.SellingTitleDaysOfWeekHashKey = "bae5f0ac-d411-4965-9edd-27446181eef6"; 
			request.SellableInventory.SellingTitleTimeRangeHashKey = "f99c8efb-059c-4a12-82b3-4f9cb889dea6"; 
			request.SellableInventory.SellableInventoryPeriodHashKey = "a76ebbb1-568e-4084-ad6d-ef410b0edd67"; 
			request.SellableInventoryDto = new SellableInventoryDto();
			request.SellableInventoryDto.SellingTitleStartDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.SellableInventoryDto.SellingTitleEndDate = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:18:15.8818354Z"), DateTimeKind.Utc)); 
			request.SellableInventoryDto.SellingTitleName = "1f0b25d2-ee00-4956-9f32-c30f3dcf4de9"; 
			request.SellableInventoryDto.RateCardDaypartName = "37e71c8d-1f5b-4d93-8cf8-6182143dda41"; 
			request.SellableInventoryDto.SellingTitleDaysOfWeekName = "3ecec981-77f9-4016-9424-ca64c5b69c10"; 
			request.SellableInventoryDto.RateCardTypeName = "79d42425-d6f2-498b-8fa9-33a1b74c40f3"; 
			request.SellableInventoryDto.SellableInventoryHashKey = "28e8e016-f7cf-4e1a-a21c-1ef99ef45620"; 
			request.SellableInventoryDto.StationHashKey = "aa66f8c7-a84b-4377-98b3-935bb3a2d271"; 
			request.SellableInventoryDto.SellingTitleDaysOfWeekHashKey = "032efa96-0b34-4d76-8488-265c92f7a5df"; 
			request.SellableInventoryDto.RateCardTypeHashKey = "80e776bf-bca6-475e-b065-7faa7710a298"; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
