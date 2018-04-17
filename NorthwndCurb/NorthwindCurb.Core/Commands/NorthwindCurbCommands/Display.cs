using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands.NorthwindCurbCommands
{
    class Display : ICommand
    {
        private string _queryString = "SELECT * FROM [";
        private SqlConnection _connection;

        public Display(string[] args, SqlConnection connection) // TODO add parsing check somewhere else.
        {
            _connection = connection;
            _queryString += args[0]+"];";
        }

        public void Execute()
        {
            SqlCommand command = new SqlCommand(_queryString, _connection);

            try
            {
                _connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("RESULTS");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (i != reader.FieldCount)
                        {
                            Console.Write(reader[i] + "\t");
                        }
                        else
                        {
                            Console.Write(reader[i]);
                        }
                    }
                    Console.WriteLine();
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }

            _connection.Close();


        }
    }
}

