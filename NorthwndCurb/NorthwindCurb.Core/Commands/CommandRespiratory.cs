using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    class CommandRespiratory
    {
        private List<ICommand> commands;

        public CommandRespiratory()
        {
            commands = new List<ICommand>();
        } 

        public void AddCommand(ICommand cmd, string inputHandle)
        {
            string s = cmd.GetType().Name;
            foreach(ICommand i in commands)
            {
                if (i.GetType().Name.Equals(s)) // Makes sure command does not already exist.
                {
                    throw new System.ArgumentException("Command already exists.");
                }
            }

            cmd.InputHandle = inputHandle; // TODO Fix input handles(Kinda fixed).
            commands.Add(cmd);
        }

        public void RemoveCommand(Type type)
        {
            ICommand temp = null;
            foreach(ICommand i in commands)
            {
                if (i.GetType().Name.Equals(type.GetType().Name)) temp = i;
            }
            if (temp != null) commands.Remove(temp);
        }

        public List<ICommand> GetCommands()
        {
            return commands;
        }

    }

}
        