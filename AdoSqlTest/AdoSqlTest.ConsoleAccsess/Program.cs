using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSqlTest.ConsoleAccsess
{
    class Program
    {
        static string userInput = "";
        static bool cont = true;
        static InputDirector inputDirector = new InputDirector();

        static void Main(string[] args)
        {          
            while (cont)
            {
                userInput = Console.ReadLine();
                cont = inputDirector.DirectInput(userInput);
            }
        }
    }
}
