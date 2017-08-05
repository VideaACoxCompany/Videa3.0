using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.SellerRatingNS.Data.DataServices
{
	public interface ISellerRatingDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
