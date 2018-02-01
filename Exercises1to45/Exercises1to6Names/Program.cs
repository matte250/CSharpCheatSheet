using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)
    {

        String firstName, lastName;
        // (Exercise 1) Write first and last name directly to console.
        PrintExercise(1, "Simple console output pt1.");
        Console.WriteLine("Mattias\nSoroccos");
        Console.ReadKey();
        // (Exercise 2) Write first and last name to console using predefined variables.
        PrintExercise(2, "Simple console output pt2.");
        firstName = "Mattias";
        lastName = "Soroccos";
        Console.WriteLine("{0}\n{1}", firstName, lastName);
        Console.ReadKey();
        // (Exercise 3) Output todays date using DateTime.Now.
        PrintExercise(3, "Simple date output.");
        Console.WriteLine(DateTime.Now);
        Console.ReadKey();
        // (Exercise 4) Ask for the users first and last name, then output them to the console.
        PrintExercise(4, "Simple console read pt1.");
        firstName = Console.ReadLine();
        lastName = Console.ReadLine();
        Console.WriteLine("{0}\n{1}", firstName, lastName);
        Console.ReadKey();
        // (Exercise 5) Prompt the user to write their first name, then last name, then display the name with a message to the console.
        PrintExercise(5, "Simple console read pt2.");
        Console.Write("Enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Enter your last name : ");
        lastName = Console.ReadLine();
        Console.WriteLine("Hello {0} {1}! :)", firstName, lastName);
        Console.ReadKey();
        // (Exercise 6) Display the name given in the last exercise, but with uppercase letters.
        PrintExercise(6, "Turn uppercase.");
        Console.WriteLine("{0} {1}", firstName.ToUpper(), lastName.ToUpper());
        Console.ReadKey();

    }

    public static void PrintExercise(int x, string desc)
    {
        // Printing format for exercise descriptions.
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("(Exercise {0}) ", x);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(desc);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(String.Concat(Enumerable.Repeat("- ", 20)));
    }

}
