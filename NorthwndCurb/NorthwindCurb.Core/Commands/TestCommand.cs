using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    class TestCommand : Command
    {
        public override int NumParameters { get; set; } = 0;

        public override void Execute(string[] args)
        {
            throw new NotImplementedException();
        }

        public override string GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
