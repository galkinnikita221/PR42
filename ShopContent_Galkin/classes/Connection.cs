﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopContent_Galkin.classes
{
	public class Connection
	{
		private static readonly string config = "server=student.permaviat.ru;" +
			"Trusted_Connection=No;" +
			"DataBase=ShopContent;" +
			"User=***;" +
			"PWF=***";

		public static SqlConnection OpenConnection()
		{
			SqlConnection connection = new SqlConnection(config);
			connection.Open();
			return connection;
		}

		public static SqlDataReader Query(string SQL, out SqlConnection connection)
		{
			connection = OpenConnection();
			return new SqlCommand(SQL, connection).ExecuteReader();
		}
		public static void CloseConnection(SqlConnection connection)
		{
			connection.Close();
			SqlConnection.ClearPool(connection);
		}
	}
}
