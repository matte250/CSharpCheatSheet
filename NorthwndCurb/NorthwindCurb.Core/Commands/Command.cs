using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    abstract class Command : ICommand
    {
        public string InputHandle { get; set; }
        public virtual int NumParameters { get; set; } = 0;

        public abstract void Execute(string[] args);
        public abstract string GetDescription();
    }
}
