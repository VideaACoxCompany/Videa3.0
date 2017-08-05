using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.CuratedRateNS.Service.TestClient
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
			var client = new CuratedRateService.CuratedRateServiceClient(channel);
			TestCuratedRateDelete(client);
			TestRateTypeDelete(client);
			TestCurationStatusDelete(client);
			TestCuratedRateAddUpdate(client);
			TestRateTypeAddUpdate(client);
			TestCurationStatusAddUpdate(client);
			TestGetConfirmedRates(client);
			TestBulkStore(client);

		}
		public  static void TestCuratedRateDelete(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new CuratedRateDeleteRequest();
			request.CuratedRateId = null; 
			var response = client.CuratedRateDelete(request);

		}
		public  static void TestRateTypeDelete(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new RateTypeDeleteRequest();
			request.RateTypeId = 1303640176; 
			var response = client.RateTypeDelete(request);

		}
		public  static void TestCurationStatusDelete(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new CurationStatusDeleteRequest();
			request.CurationStatusId = 1303640176; 
			var response = client.CurationStatusDelete(request);

		}
		public  static void TestCuratedRateAddUpdate(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new CuratedRateAddUpdateRequest();
			request.CuratedRate = new CuratedRate();
			request.CuratedRate.CuratedRateId = null; 
			request.CuratedRate.SellableInventoryHashKey = "e5230fec-7b6b-4351-a6a9-1f662392ea91"; 
			request.CuratedRate.RateHashKey = "dce59e25-eccb-40c8-9d44-997ea8b8e41b"; 
			request.CuratedRate.RateVersion = 1303640176; 
			request.CuratedRate.CuratedRateValue = "f160345f-0106-464f-a85e-fa04029d99bc"; 
			request.CuratedRate.IsDynamicRate = true; 
			request.CuratedRate.RateTypeId = 1303640176; 
			request.CuratedRate.CurationStatusId = 1303640176; 
			request.CuratedRate.CreatedBy = "1fe83856-7351-4888-8fd9-46a5fa2a49c5"; 
			request.CuratedRate.ModifiedBy = "bb7923d9-27df-421b-b9c2-c28cc07d4ed2"; 
			request.CuratedRate.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:19:10.5028481Z"), DateTimeKind.Utc)); 
			var response = client.CuratedRateAddUpdate(request);

		}
		public  static void TestRateTypeAddUpdate(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new RateTypeAddUpdateRequest();
			request.RateType = new RateType();
			request.RateType.RateTypeId = 1303640176; 
			request.RateType.RateTypeName = "7090517b-27b6-4ecf-9596-fe35031041cb"; 
			request.RateType.RateTypeDescription = "05c0b0b8-e615-4f6f-9113-01ac19fa5eea"; 
			var response = client.RateTypeAddUpdate(request);

		}
		public  static void TestCurationStatusAddUpdate(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new CurationStatusAddUpdateRequest();
			request.CurationStatus = new CurationStatus();
			request.CurationStatus.CurationStatusId = 1303640176; 
			request.CurationStatus.CurationStatusName = "d9dfe2c7-656c-46aa-ae72-69890b7f9cf2"; 
			request.CurationStatus.CurationStatusDescription = "a2ad3421-9814-48a3-9754-8af0b41879cf"; 
			var response = client.CurationStatusAddUpdate(request);

		}
		public  static void TestGetConfirmedRates(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new GetConfirmedRatesRequest();
			request.SellableInventoryList = "2491099f-f973-4166-a8cd-99cff52ec643"; 
			var response = client.GetConfirmedRates(request);

		}
		public  static void TestBulkStore(CuratedRateService.CuratedRateServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.CuratedRate = new CuratedRate();
			request.CuratedRate.CuratedRateId = null; 
			request.CuratedRate.SellableInventoryHashKey = "f70db604-1abe-49e9-84c2-7d635f40ae00"; 
			request.CuratedRate.RateHashKey = "2def762e-b560-4c45-b962-8d4977a65063"; 
			request.CuratedRate.RateVersion = 1303640176; 
			request.CuratedRate.CuratedRateValue = "faea49fc-8473-46fc-880d-e12736d96b8b"; 
			request.CuratedRate.IsDynamicRate = true; 
			request.CuratedRate.RateTypeId = 1303640176; 
			request.CuratedRate.CurationStatusId = 1303640176; 
			request.CuratedRate.CreatedBy = "b4763e45-13aa-4795-a214-3f440b60e89c"; 
			request.CuratedRate.ModifiedBy = "a73a1989-ac22-445b-8468-294d145db1ee"; 
			request.CuratedRate.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:19:10.5028481Z"), DateTimeKind.Utc)); 
			request.RateType = new RateType();
			request.RateType.RateTypeId = 1303640176; 
			request.RateType.RateTypeName = "91bfdca3-0444-4c21-809b-7e801a85fa81"; 
			request.RateType.RateTypeDescription = "db09026d-41ee-42b1-893a-160c6c0ac0e9"; 
			request.CurationStatus = new CurationStatus();
			request.CurationStatus.CurationStatusId = 1303640176; 
			request.CurationStatus.CurationStatusName = "1639870e-1d35-4e08-9348-37e9ba46c8db"; 
			request.CurationStatus.CurationStatusDescription = "68fb51ac-640c-4081-84b3-5c1fd34653dc"; 
			request.Rate = new Rate();
			request.Rate.todo = 1303640176; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
