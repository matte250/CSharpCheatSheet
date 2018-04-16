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
            //// Test
            //string test = "Snopp [BAJS KORV] sugmig  ";
            //string[] ts = test.GetParams();
            //Console.WriteLine(test);
            //foreach(string s in ts)
            //{
            //    Console.Write(s+" ");
            //}
            //Console.WriteLine("!");
            // Connection init.
            string str = Console.ReadLine();
            switch (str)
            {
                case "lol":
                    Console.WriteLine("ay lmao");
                    break;
            }

            string connectionString =
            "Data Source=(local);Initial Catalog=NORTHWND;"
            + "Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Paramex.GetParams("display [Order Details]");
                // Commands init.
                ShowTables st = new ShowTables(connection);

                // Adding commands.
                CommandRespiratory cr = new CommandRespiratory();
                cr.AddCommand("helloworld", typeof(HelloWorld), (string[] param) => new HelloWorld());
                cr.AddCommand("clear", typeof(ClearConsole), (string[] param) => new ClearConsole());
                cr.AddCommand("showtables", typeof(ShowTables), (string[] param) => new ShowTables(connection));
                cr.AddCommand("display", typeof(Display), (string[] param) => new Display(param, connection));

                CommandDirector cd = new CommandDirector(cr);
                cd.Title = "NORTHWND Test";
                cd.Start();



                

            }
        }
    }
}
