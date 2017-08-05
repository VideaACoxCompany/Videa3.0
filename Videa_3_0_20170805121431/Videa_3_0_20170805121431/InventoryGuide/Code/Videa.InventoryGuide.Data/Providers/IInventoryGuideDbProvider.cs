using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.InventoryGuideNS.Data.DataServices
{
	public interface IInventoryGuideDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
