﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Videa.TrafficStatisticNS.Data.DataServices
{
	public class TrafficStatisticDbProvider : ITrafficStatisticDbProvider
	{
		#region Fields
		private  readonly  string _connectionString;
		#endregion Fields
		#region Properties
		#endregion Properties
		#region Constructors
		public TrafficStatisticDbProvider(string connectionString)
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
