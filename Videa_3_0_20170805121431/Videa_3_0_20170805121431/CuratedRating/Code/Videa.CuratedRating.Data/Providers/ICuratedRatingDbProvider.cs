using System;
using System.Data;
using System.Data.SqlClient;
namespace Videa.CuratedRatingNS.Data.DataServices
{
	public interface ICuratedRatingDbProvider
	{
		//methods go here
		IDbConnection GetConnection();
	}
}
