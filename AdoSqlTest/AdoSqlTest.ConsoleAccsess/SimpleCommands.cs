using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdoSqlTest.ConsoleAccsess.InputCheck;

namespace AdoSqlTest.ConsoleAccsess
{
    static class SimpleCommands
    {
        public static void ClearConsole()
        {
            Console.Clear();
        }

        public static void PrintCommands()
        {
            foreach(InputDef i in definedInputs)
            {
                Console.WriteLine(i.ToString()); 
            }
        }
    }
}
