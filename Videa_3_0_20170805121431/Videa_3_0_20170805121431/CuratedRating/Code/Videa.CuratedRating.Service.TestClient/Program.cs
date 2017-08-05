using System;
using System.Collections.Generic;
using Grpc.Core;
using Google.Protobuf.WellKnownTypes;

namespace Videa.CuratedRatingNS.Service.TestClient
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
			var client = new CuratedRatingService.CuratedRatingServiceClient(channel);
			TestCuratedRatingDelete(client);
			TestRatingTypeDelete(client);
			TestCurationStatusDelete(client);
			TestCuratedRatingAddUpdate(client);
			TestRatingTypeAddUpdate(client);
			TestCurationStatusAddUpdate(client);
			TestGetConfirmedRatings(client);
			TestBulkStore(client);

		}
		public  static void TestCuratedRatingDelete(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new CuratedRatingDeleteRequest();
			request.CuratedRatingId = null; 
			var response = client.CuratedRatingDelete(request);

		}
		public  static void TestRatingTypeDelete(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new RatingTypeDeleteRequest();
			request.RatingTypeId = 471380170; 
			var response = client.RatingTypeDelete(request);

		}
		public  static void TestCurationStatusDelete(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new CurationStatusDeleteRequest();
			request.CurationStatusId = 471380170; 
			var response = client.CurationStatusDelete(request);

		}
		public  static void TestCuratedRatingAddUpdate(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new CuratedRatingAddUpdateRequest();
			request.CuratedRating = new CuratedRating();
			request.CuratedRating.CuratedRatingId = null; 
			request.CuratedRating.SellableInventoryHashKey = "9cd29527-9a7e-4032-9d74-208601135cce"; 
			request.CuratedRating.RatingHashKey = "ac8f6917-172d-49dc-bf0c-ddbd7b243c15"; 
			request.CuratedRating.RatingVersion = 471380170; 
			request.CuratedRating.IsDynamicRating = true; 
			request.CuratedRating.CuratingRatingValue = "3f9a5498-cd50-4eff-a4f3-2ca922e5c772"; 
			request.CuratedRating.RatingTypeId = 471380170; 
			request.CuratedRating.CurationStatusId = 471380170; 
			request.CuratedRating.CreatedBy = "71288204-7a19-4b96-a771-979c3f85477f"; 
			request.CuratedRating.ModifiedBy = "c345dccd-fef4-4654-80c2-b3f694f620c7"; 
			request.CuratedRating.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:19:53.7818348Z"), DateTimeKind.Utc)); 
			var response = client.CuratedRatingAddUpdate(request);

		}
		public  static void TestRatingTypeAddUpdate(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new RatingTypeAddUpdateRequest();
			request.RatingType = new RatingType();
			request.RatingType.RatingTypeId = 471380170; 
			request.RatingType.RatingTypeName = "62d8ef7c-ec73-4127-aa4e-98b79675ab47"; 
			request.RatingType.RatingTypeDescription = "4d578f9f-6f0a-4293-a93f-8b6f141cf809"; 
			var response = client.RatingTypeAddUpdate(request);

		}
		public  static void TestCurationStatusAddUpdate(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new CurationStatusAddUpdateRequest();
			request.CurationStatus = new CurationStatus();
			request.CurationStatus.CurationStatusId = 471380170; 
			request.CurationStatus.CurationStatusName = "6eabcf61-04af-4d34-8836-c850bce266a7"; 
			request.CurationStatus.CurationStatusDescription = "b7bf1913-718f-4e4e-a635-bba26b1a9412"; 
			var response = client.CurationStatusAddUpdate(request);

		}
		public  static void TestGetConfirmedRatings(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new GetConfirmedRatingsRequest();
			request.SellableInventoryList = "ec1a656f-a687-4d25-8f10-5d70b5e10e5e"; 
			var response = client.GetConfirmedRatings(request);

		}
		public  static void TestBulkStore(CuratedRatingService.CuratedRatingServiceClient client)
		{
			var request = new BulkStoreRequest();
			request.CuratedRating = new CuratedRating();
			request.CuratedRating.CuratedRatingId = null; 
			request.CuratedRating.SellableInventoryHashKey = "ff7b26ae-497d-4e46-be51-eb4c85981ef9"; 
			request.CuratedRating.RatingHashKey = "6c6ca808-0dd1-4553-85ce-43a606e843e5"; 
			request.CuratedRating.RatingVersion = 471380170; 
			request.CuratedRating.IsDynamicRating = true; 
			request.CuratedRating.CuratingRatingValue = "182cc958-654a-4a88-9d58-e25930cd9de8"; 
			request.CuratedRating.RatingTypeId = 471380170; 
			request.CuratedRating.CurationStatusId = 471380170; 
			request.CuratedRating.CreatedBy = "05c46d02-f36a-4279-888b-a0533e79a01e"; 
			request.CuratedRating.ModifiedBy = "294c7c0d-6747-4318-9777-c0ac5fa0370c"; 
			request.CuratedRating.RowVersion = Timestamp.FromDateTime(DateTime.SpecifyKind(  DateTime.Parse("2017-08-05T17:19:53.7818348Z"), DateTimeKind.Utc)); 
			request.RatingType = new RatingType();
			request.RatingType.RatingTypeId = 471380170; 
			request.RatingType.RatingTypeName = "d1271e10-d2f8-4000-a0e0-727c85729ed3"; 
			request.RatingType.RatingTypeDescription = "39586d1c-3d09-4181-9cc7-5e11e2431e2a"; 
			request.CurationStatus = new CurationStatus();
			request.CurationStatus.CurationStatusId = 471380170; 
			request.CurationStatus.CurationStatusName = "f261fa54-5918-4df2-b07a-4fcf54410695"; 
			request.CurationStatus.CurationStatusDescription = "d77d1b27-2d1d-4e26-84d9-0f1873b14567"; 
			request.Rating = new Rating();
			request.Rating.todo = 471380170; 
			var response = client.BulkStore(request);

		}
		#endregion Methods
	}
}
