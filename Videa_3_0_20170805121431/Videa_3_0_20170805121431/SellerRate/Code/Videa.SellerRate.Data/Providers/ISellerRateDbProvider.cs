using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.SellerRateNS.Data.DataServices
{
	public interface ISellerRateDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
