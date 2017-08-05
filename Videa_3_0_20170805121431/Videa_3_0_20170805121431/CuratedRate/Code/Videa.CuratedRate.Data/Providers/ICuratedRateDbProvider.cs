using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.CuratedRateNS.Data.DataServices
{
	public interface ICuratedRateDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
