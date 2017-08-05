using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.CuratedRatingNS.Data.DataServices;
namespace Videa.CuratedRatingNS.Data.DataServices
{
	public interface ICuratedRatingDataService
	{
		//methods go here
		Task<bool> CuratedRatingDelete(System.Int64 curatedratingid);
		Task<bool> RatingTypeDelete(System.Int32 ratingtypeid);
		Task<bool> CurationStatusDelete(System.Int32 curationstatusid);
		Task<bool> CuratedRatingAddUpdate(CuratedRating curatedrating);
		Task<bool> RatingTypeAddUpdate(RatingType ratingtype);
		Task<bool> CurationStatusAddUpdate(CurationStatus curationstatus);
		Task<IList<Rating>> GetConfirmedRatings(object sellableinventorylist);
	}
}
