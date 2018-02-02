using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int x, z, sum;
        String str;
        // (Exercise 20) Ask the user to enter a value. If the value is greater than zero, then iterate value x amount of times.
        // Print each iteration.

        PrintExercise(20, "Simple iteration.");

        Console.Write("Enter value: ");
        x = Int32.Parse(Console.ReadLine());
        if (x > 0)
        {
            for (int i = 0; i < x; i++)
                Console.WriteLine(i);
        }

        Console.ReadKey();
'
            '
        // (Exercise 21) Ask the user to enter a value. If the value is greater than zero, then iterate value x amount of times bakwards.
        // Print each iteration.

        PrintExercise(21, "Simple backwards iteration.");

        Console.Write("Enter value: ");
        x = Int32.Parse(Console.ReadLine());
        if (x > 0)
        {
            for (int i = x - 1; i >= 0; i--)
                Console.WriteLine(i);
        }

        Console.ReadKey();

        // (Exercise 22) Ask the user to enter a value. If the value is greater than zero, then interate value x amount of times.
        // Print each iteration divisible by 2.

        PrintExercise(22, "Modulus(%2) iteration.");

        Console.Write("Enter value: ");
        x = Int32.Parse(Console.ReadLine());
        if (x > 0)
        {
            for (int i = 0; i < x; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

        }

        Console.ReadKey();

        // (Exercise 23) Print out a multiplication table using iteration.

        PrintExercise(23, "Multiplication table.");

        for (int y = 1; y < 11; y++)
        {
            for (int i = 1; i < 11; i++)
            {
                if (i * y < 10)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(" ");
                }
                Console.Write(i * y);
            }
            Console.WriteLine();
        }

        Console.ReadKey();

        // (Exercise 24) Ask the user to enter a value. If the value is greater than zero, then iterate value x amount of times.
        // Print each iteration to the power of 2 and its caluation.

        PrintExercise(24, "Math.Pow iteration.");

        Console.Write("Enter value: ");
        x = Int32.Parse(Console.ReadLine());
        if (x > 0)
        {
            for (int i = 0; i < x; i++)
                Console.WriteLine(i + "raised to the power of 2 is equal to " + Math.Pow(i, 2));
        }

        Console.ReadKey();

        // (Exercise 25) Output dashes to the console that iterate backwards.

        PrintExercise(25, "String manipulation iteration.");

        str = String.Concat(Enumerable.Repeat("- ", 5));
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(str);
            str = str.Substring(2);
        }

        Console.ReadKey();

        // (Exercise 26) Keep asking the user to input values into the user inputs the value -1. When the user inputs -1
        // display the sum and average of all the values the user has entered.

        PrintExercise(26, "Variable iteration.");

        int total = 0, lastValue = 0, iterations = 0;
        Console.Write("Enter value: ");
        lastValue = Int32.Parse(Console.ReadLine());
        while (lastValue != -1)
        {
            iterations += 1;
            total += lastValue;
            Console.Write("Enter value: ");
            lastValue = Int32.Parse(Console.ReadLine());
        }



        if (iterations != 0)
        {
            Console.WriteLine("Sum: {0}.\n" +
                "Average: {1}", total, (double)total / iterations);
        }
        else
        {
            Console.WriteLine("You didnt enter any values.");
        }

        Console.ReadKey();

        // (Exercise 27) Ask the user to input a value, then display all the values that the input can be divisible by.

        PrintExercise(27, "Divisible iteration.");

        Console.Write("Input value: ");
        x = Int32.Parse(Console.ReadLine());
        for (int i = 1; i < x; i++)
        {
            if (x % i == 0) Console.WriteLine(i);
        }

        Console.ReadKey();

        // (Exercise 28) Use iteration to print out atleast the first three perfect numbers.

        PrintExercise(28, "Perfect number iteration.");

        sum = 0;
        Console.Write("Enter iteration value: ");
        x = Int32.Parse(Console.ReadLine());

        for (int i = 1; i < x; i++)
        {
            sum = 0;
            for (int n = 1; n < i; n++)
            {
                if (i % n == 0)
                {
                    sum = sum + n;
                }
            }
            if (sum == i)
            {
                Console.WriteLine(sum);
            }
        }

        Console.ReadKey();

        // (Exercise 29) Ask the user to input a value. Then use this to iterate Fibonacci value x amount of times.

        PrintExercise(29, "Fibonacci iteration.");

        int a = 0, b = 1, temp = 0;
        Console.Write("Enter value: ");
        x = Int32.Parse(Console.ReadLine());
        Console.WriteLine("0\n1");

        for (int i = 0; i < x; i++)
        {
            temp = a + b;
            Console.WriteLine(temp);
            a = b;
            b = temp;
        }

        Console.ReadKey();

        // (Exercise 30) Ask the user to input a value, then iterate dashes to the console that goes back and forth.

        PrintExercise(30, "Double string iteration.");
        Console.Write("Enter value: ");
        x = Int32.Parse(Console.ReadLine());
        str = String.Concat(Enumerable.Repeat("- ", x));

        for (int i = x; i >= 1; i--)
        {
            Console.WriteLine(String.Concat(Enumerable.Repeat("- ", i)));
        }

        for (int i = 1; i < x + 1; i++)
        {
            Console.WriteLine(String.Concat(Enumerable.Repeat("- ", i)));
        }

        Console.ReadKey();



        // (Exercise 31) Let the user input a string, then check if that string is a palindrome.

        PrintExercise(31, "Palindrome iteration");

        String tempStr = "";

        Console.Write("Write a word or sentence: ");
        str = Console.ReadLine().ToLower().Replace(" ", "");

        for (int i = str.Length - 1; i >= 0; i--)
        {
            tempStr += str[i];
        }

        if (str.Equals(tempStr))
        {
            Console.WriteLine("Your input is a palindrome! :D");
        }
        else
        {
            Console.WriteLine("Your input isnt a palindrome. :C");
        }

        Console.ReadKey();

        // (Exercise 32) Make a menu system using a while loop. The menu should have 4 different options, and 3 of those
        // options should lead back to the menu.

        bool menu = true;
        while (menu)
        {
            PrintExercise(32, "While-Loop menu.");

            Console.WriteLine("MENU\n" +
                "1. Addition\n" +
                "2. String multiplication\n" +
                "3. Uppercase string\n" +
                "4. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    PrintExercise(32, "While-Loop menu.");
                    Console.WriteLine("ADDITION");
                    Console.Write("Enter value A: ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter value B: ");
                    z = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", x + z);
                    Console.ReadKey();
                    break;
                case "2":
                    PrintExercise(32, "While-Loop menu.");
                    Console.WriteLine("STRING MULTIPLICATION");
                    Console.Write("Enter string: ");
                    str = Console.ReadLine();
                    Console.Write("Enter value: ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + String.Concat(Enumerable.Repeat(str, x)));
                    Console.ReadKey();
                    break;
                case "3":
                    PrintExercise(32, "While-Loop menu.");
                    Console.WriteLine("UPPERCASE STRING");
                    Console.Write("Enter string: ");
                    str = Console.ReadLine();
                    Console.WriteLine("Result: " + str.ToUpper());
                    Console.ReadKey();
                    break;
                case "4":
                    menu = false;
                    break;
                default:
                    PrintExercise(32, "While-Loop menu.");
                    Console.WriteLine("Invalid input.");
                    Console.ReadKey();
                    break;
            }
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
