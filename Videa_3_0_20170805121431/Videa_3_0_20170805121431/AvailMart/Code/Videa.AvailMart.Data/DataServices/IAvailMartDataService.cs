using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Videa.AvailMartNS.Data.DataServices;
namespace Videa.AvailMartNS.Data.DataServices
{
	public interface IAvailMartDataService
	{
		//methods go here
		Task<bool> AvailMartDelete(System.String availmarthashkey);
		Task<bool> AvailListDelete(System.String availlisthashkey);
		Task<bool> AvailLineWithDetailedPeriodsDelete(System.String availlinewithdetailedperiodshashkey);
		Task<bool> DetailedPeriodDelete(System.String detailedperiodhashkey);
		Task<bool> AvailMartAddUpdate(AvailMart availmart);
		Task<bool> AvailListAddUpdate(AvailList availlist);
		Task<bool> AvailLineWithDetailedPeriodsAddUpdate(AvailLineWithDetailedPeriods availlinewithdetailedperiods);
		Task<bool> DetailedPeriodAddUpdate(DetailedPeriod detailedperiod);
		Task<IList<AvailMart>> GetAvailMart(System.String stationhashkey, System.String ratecardtypehashkey, System.String dayparthashkey, object broadcastweeklist);
	}
}
