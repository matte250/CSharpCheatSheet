using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSqlTest.ConsoleAccsess
{
    static class InputCheck
    {
        // Define valid inputs.
        public enum ValidInputs
        {
            Commands,
            Clear,
            ShowTables,
            Exit
        }
              
        public static InputDef[] definedInputs = new InputDef[]
        {
            new InputDef(ValidInputs.Commands, 0),
            new InputDef(ValidInputs.Clear, 0),
            new InputDef(ValidInputs.ShowTables, 0),
            new InputDef(ValidInputs.Exit, 0)
        };

        public static InputDef CheckValidInput(string str)
        {
            // Go thru each valid input.
            foreach(InputDef i in definedInputs)
            {
                if(i.numParameters == 0) // Checking if input needs parameters.
                {
                    if (str.ToUpper().Equals(i.ToString().ToUpper())) return i;
                }
            }
            return null;
        }
    }
}
