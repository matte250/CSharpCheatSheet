using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdoSqlTest.ConsoleAccsess.InputCheck;

namespace AdoSqlTest.ConsoleAccsess
{
    // Class to define new commands.
    class InputDef
    {
        public ValidInputs InputName { get; private set; }
        public int numParameters { get; private set; }

        public InputDef(ValidInputs inputName, int parameters)
        {
            InputName = inputName;
            numParameters = parameters;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(ValidInputs), InputName);
        }
    }
}
