using NorthwindCurb.Core.Commands;
using NorthwindCurb.Core.Commands.NorthwindCurbCommands;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindCurb.Core.Utility;

namespace NorthwindCurb.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test
            string test = "Snopp";

            Console.WriteLine(test);
            Console.WriteLine(Paramex.GetParamCount(test));
            // Connection init.
            string connectionString =
            "Data Source=(local);Initial Catalog=NORTHWND;"
            + "Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Commands init.
                ShowTables st = new ShowTables(connection);

                // Adding commands.
                CommandRespiratory cr = new CommandRespiratory();
                cr.AddCommand(new ClearConsole(), "clear");
                cr.AddCommand(new HelloWorld(), "helloworld");
                cr.AddCommand(st, "showtables");

                CommandDirector cd = new CommandDirector(cr);
                cd.Title = "NORTHWND Test";
                cd.Start();

            }
        }
    }
}
