using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        /* (Exercise 44)
         * Create a program that generates 7 unique numbers into an array. The numbers should be between 1
         * and 40. The numbers may only appear once in the array!
         */

        PrintExercise(44, "Unique number array/list.");

        List<int> intList = new List<int>();
        Random r = new Random();
        int number = r.Next(40);
        for (int i = 0; i < 7; i++)
        {
            while (intList.Contains(number))
            {
                number = r.Next(40);
            }
            intList.Add(number);
        }

        foreach (int i in intList)
        {
            Console.WriteLine(i);
        }

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

