using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Videa.CuratedRatingNS.Data.DataServices
{
	public class CuratedRatingDbProvider : ICuratedRatingDbProvider
	{
		#region Fields
		private  readonly  string _connectionString;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public CuratedRatingDbProvider(string connectionString)
		{
			  if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString));
            }

            _connectionString = connectionString;
            
		}
		#endregion Constructors
		#region Methods
		public  IDbConnection GetConnection()
		{
			return new SqlConnection(_connectionString);
		}
		#endregion Methods
	}
}
