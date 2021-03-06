﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands.NorthwindCurbCommands
{
    class ShowTables : ICommand
    {

        private string _queryString = "SELECT TABLE_NAME FROM " +
            "INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'";
        private SqlConnection _connection;

        public ShowTables(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Execute()
        {

            SqlCommand command = new SqlCommand(_queryString, _connection);
            _connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write("{0}\t", reader[i]);
                }
                Console.WriteLine();
            }

            reader.Close();
            _connection.Close();

        }

    }
}
