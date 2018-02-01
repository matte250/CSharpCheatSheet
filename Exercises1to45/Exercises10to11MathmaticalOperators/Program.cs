using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        float d;

        // (Exercise 10) Calculate the following code on paper before running it.

        PrintExercise(10, "Calculation hypofosis.");

        a = 10;
        b = 3;
        c = 7;
        d = 7 / 2.0f;
        double result = ((double)a / b) * 2;
        Console.WriteLine(result);
        result = a / (b + c) + 9f;
        Console.WriteLine(result);
        result = a * a / (b + c);
        Console.WriteLine(result);
        result = a * (b + a) - 100;
        Console.WriteLine(result);

        Console.ReadKey();

        // (Exercise 11) Let the user input a decimal number, output the square root of that number and that number raised to the power of 2,3 and 10.

        PrintExercise(11, "Simple sqr and pow.");

        Console.Write("Enter a decimal value: ");
        d = float.Parse(Console.ReadLine());
        d = (float)Math.Sqrt(d + Math.Pow(d, 2) + Math.Pow(d, 3) + Math.Pow(d, 10));
        Console.WriteLine("Result: " + d);

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
