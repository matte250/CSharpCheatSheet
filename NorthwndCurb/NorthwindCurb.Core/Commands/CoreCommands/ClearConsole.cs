﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    class ClearConsole : ICommand
    {
        public void Execute()
        {
            Console.Clear();
        }   
    }
}
