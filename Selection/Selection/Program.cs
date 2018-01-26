using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            int temp;

            // (Exercise 12) Ask the user to input a name. If the name is Bob or Alice, then display "Hi Bob!" or "Hi Alice!".

            Console.Write("Enter name: ");
            str = Console.ReadLine().ToLower();
            if (str.Contains("bob")) Console.WriteLine("Hi Bob!");
            if (str.Contains("alice")) Console.WriteLine("Hi Alice!");

            // (Exercise 13) Ask the user to input a number. if that number is divesible by 4, then display the result.

            Console.Write("Enter a number divisible by 4: ");
            temp = Int32.Parse(Console.ReadLine());
            if (temp % 4 == 0)
            {
                Console.WriteLine(temp/4);
            }
            else
            {
                Console.WriteLine("Your number isnt divisble by 4.");
            }

        }
    }
}
