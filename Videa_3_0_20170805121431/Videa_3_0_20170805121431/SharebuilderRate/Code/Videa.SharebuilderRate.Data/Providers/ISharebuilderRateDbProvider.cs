using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.SharebuilderRateNS.Data.DataServices
{
	public interface ISharebuilderRateDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
