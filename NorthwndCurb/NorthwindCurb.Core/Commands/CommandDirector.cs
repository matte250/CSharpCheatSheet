using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindCurb.Core.Commands
{
    class CommandDirector
    {
        public CommandRespiratory SetCommandRespiratory { private get; set; }
        public string Title { get; set; }

        public CommandDirector(CommandRespiratory cr)
        {
            SetCommandRespiratory = cr;
            Title = "";
        }

        public void Start()
        {
            Runner();
        }

        private void Runner()
        {
            PrintTitle();
            Console.Write("> ");
            string input = Console.ReadLine(); // TODO Add proper input check

            foreach(ICommand i in SetCommandRespiratory.GetCommands())
            {
                if (i.InputHandle.Equals(input))
                {
                    i.Execute(new string[0]);
                }
            }

            if (input.Equals("commands")) Commands();

            if(!input.Equals("exit")) Runner();

        }

        private void PrintTitle()
        {
            if (!String.IsNullOrEmpty(Title) && Console.CursorTop == 0) // Display title if it exists.
            {
                Console.WriteLine(Title);
            }
        }

        private void Commands()
        {
            foreach(ICommand i in SetCommandRespiratory.GetCommands())
            {
                Console.WriteLine("{0}\t\t-{1}",i.InputHandle,i.GetDescription());
            }
        }

    }
}
