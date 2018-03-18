using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core
{
    interface ICommand
    {
        string InputHandle { get; set; }
        int NumParameters { get; set; }

        void Execute(string[] args);
        string GetDescription();
    }
}
