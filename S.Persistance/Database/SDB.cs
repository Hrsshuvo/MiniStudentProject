﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Persistance.Database
{
    public class SDB
    {
        public static string ConnectionString()
        {
            var connectionString= @"Server = localhost; Database = Stududu; Trusted_Connection = true";
            return connectionString;
        }

        public int ExecuteNonQuery(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var rowAffected = command.ExecuteNonQuery();
                connection.Close();
                return rowAffected;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public SqlDataReader ExecuteReader(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataAdapter ExecuteAdapter(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                return adapter;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public decimal ExecuteScalar(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();

                var command = new SqlCommand(query, connection);
                object success = command.ExecuteScalar();
                connection.Close();
                return Convert.ToDecimal(success);
            }
            catch (Exception)
            {

                return 0;
            }

        }
    }
}
