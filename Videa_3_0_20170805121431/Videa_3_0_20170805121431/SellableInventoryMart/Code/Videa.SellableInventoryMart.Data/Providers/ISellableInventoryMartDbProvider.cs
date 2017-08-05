using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.SellableInventoryMartNS.Data.DataServices
{
	public interface ISellableInventoryMartDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
