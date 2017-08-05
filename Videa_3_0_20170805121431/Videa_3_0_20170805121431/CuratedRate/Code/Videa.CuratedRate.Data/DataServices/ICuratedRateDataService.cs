using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.CuratedRateNS.Data.DataServices;
namespace Videa.CuratedRateNS.Data.DataServices
{
	public interface ICuratedRateDataService
	{
		//methods go here
		Task<bool> CuratedRateDelete(System.Int64 curatedrateid);
		Task<bool> RateTypeDelete(System.Int32 ratetypeid);
		Task<bool> CurationStatusDelete(System.Int32 curationstatusid);
		Task<bool> CuratedRateAddUpdate(CuratedRate curatedrate);
		Task<bool> RateTypeAddUpdate(RateType ratetype);
		Task<bool> CurationStatusAddUpdate(CurationStatus curationstatus);
		Task<IList<Rate>> GetConfirmedRates(object sellableinventorylist);
	}
}
