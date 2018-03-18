using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands.NorthwindCurbCommands
{
    class ShowTables : Command
    {

        private string queryString = "SELECT TABLE_NAME FROM " +
            "INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'";
        private SqlConnection connection;

        public ShowTables(SqlConnection connection)
        {
            this.connection = connection;
        }

        public override void Execute(string[] args)
        {

            SqlCommand command = new SqlCommand(queryString, connection);
            connection.Open();
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
            connection.Close();

        }

        public override string GetDescription()
        {
            return "Shows all base tables in database.";
        }
    }
}
