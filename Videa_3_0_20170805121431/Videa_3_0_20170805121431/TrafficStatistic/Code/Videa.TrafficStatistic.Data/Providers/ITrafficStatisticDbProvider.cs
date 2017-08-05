using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.TrafficStatisticNS.Data.DataServices
{
	public interface ITrafficStatisticDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
