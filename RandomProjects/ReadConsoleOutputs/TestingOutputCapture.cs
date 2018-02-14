using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadConsoleOutputs
{
    class TestingOutputCapture
    {
        static void Main(string[] args)
        {
            string stuff = "";
            // Wrap your code in this using statement...
            using (var outputCapture = new OutputCapture())
            {
                Console.Write("test");
                Console.Write(".");
                Console.WriteLine("..");
                Console.Write("Second line");
                // Now you can look in this exact copy of what you've been outputting.
                stuff = outputCapture.Captured.ToString();
            }

            Console.WriteLine(stuff.ToString());
            Console.WriteLine(stuff);
        }
    }
}
