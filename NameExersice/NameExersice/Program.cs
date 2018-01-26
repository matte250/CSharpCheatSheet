using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameExersice
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            String firstName, lastName;
            // (Exercise 1) Write first and last name directly to console.
            Console.WriteLine("Mattias\nSoroccos");
            // (Exercise 2) Write first and last name to console using predefined variables.
            firstName = "Mattias";
            lastName = "Soroccos";
            Console.WriteLine("{0}\n{1}", firstName, lastName);
            // (Exercise 3) Output todays date using DateTime.Now.
            Console.WriteLine(DateTime.Now);
            // (Exercise 4) Ask for the users first and last name, then output them to the console.
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            Console.WriteLine("{0}\n{1}", firstName, lastName);
            // (Exercise 5) Prompt the user to write their first name, then last name, then display the name with a message to the console.
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name : ");
            lastName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}! :)", firstName, lastName);
            // (Exercise 6) Display the name given in the last exercise, but with uppercase letters.
            Console.WriteLine("{0} {1}", firstName.ToUpper(), lastName.ToUpper());

        }
    }
}
