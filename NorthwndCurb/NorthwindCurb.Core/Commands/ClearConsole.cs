using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    class ClearConsole : Command
    {
        public override void Execute(string[] args)
        {
            Console.Clear();
        }

        public override string GetDescription()
        {
            return "Clears the screen.";
        }
    }
}
