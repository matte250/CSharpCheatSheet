using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    class HelloWorld : Command
    {

        public override void Execute(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public override string GetDescription()
        {
            return "";
        }
    }
}
