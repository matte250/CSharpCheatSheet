using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdoSqlTest.ConsoleAccsess.InputCheck;

namespace AdoSqlTest.ConsoleAccsess
{
    class InputDirector
    {
        public InputDirector()
        {

        }

        public bool DirectInput(string str)
        {
            InputDef inputDef = InputCheck.CheckValidInput(str);
            if (inputDef != null) // If input is valid.
            {
                switch (inputDef.InputName)
                { 
                    case ValidInputs.Commands:
                        SimpleCommands.PrintCommands(); break;
                    case ValidInputs.Clear:
                        SimpleCommands.ClearConsole(); break;
                    case ValidInputs.ShowTables:
                        SimpleCommands.PrintCommands(); break;
                    case ValidInputs.Exit: // Exit loop.
                        return false; break;

                }
            }

            return true;
        }
    }
}
