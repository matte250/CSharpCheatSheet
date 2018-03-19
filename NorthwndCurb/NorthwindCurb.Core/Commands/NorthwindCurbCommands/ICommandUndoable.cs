using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands.NorthwindCurbCommands
{
    interface ICommandUndoable : ICommand
    {
        void Undo();
    }
}
