using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Read_Test
{
    class Program
    {

        static String connectionString = "Server=Elev;Database=NORTHWND;Trusted_Connection=True;";
        static string queryString = "SELECT CustomerID, ContactName FROM Customers;";

        static void Main(string[] args)
        {
            using (SqlConnection connectionSql =
            new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connectionSql);
                connectionSql.Open();
                SqlDataReader reader = command.ExecuteReader();

                
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}",
                        reader[0], reader[1]);
                }
                reader.Close();
                connectionSql.Close();
            }
        }
    }
}
