using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.AvailMartNS.Data.DataServices
{
	public interface IAvailMartDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
