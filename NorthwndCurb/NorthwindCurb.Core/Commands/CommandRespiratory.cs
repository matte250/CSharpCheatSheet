using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    class CommandRespiratory
    {
        private Dictionary<string, Tuple<Type, Func<string[], ICommand>>> _commands = new Dictionary<string, Tuple<Type, Func<string[], ICommand>>>();

        public CommandRespiratory()
        {

        }

        public void AddCommand(string inputHandle, Type type, Func<string[], ICommand> func)
        {
            _commands.Add(inputHandle, new Tuple<Type, Func<string[], ICommand>>(type, func));
        }

        public void RemoveCommand(Type type)
        {

        }

        public Func<string[], ICommand> GetFunction(string inputHandle)
        {

            return _commands[inputHandle].Item2;

        }

        public bool InputHandleExists(string inputHandle)
        {

            return _commands.ContainsKey(inputHandle);
        }

        public Type[] GetCommands()
        {
            return _commands.Select(kvp => kvp.Value.Item1).ToArray();
        }

    }

}
