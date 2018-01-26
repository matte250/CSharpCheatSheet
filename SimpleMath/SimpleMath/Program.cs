using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            float d;

            // (Exercise 10) Calculate the following code on paper before running it.

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

            // (Exercise 11) Let the user input a decimal number, output the square root of that number and that number raised to the power of 2,3 and 10.
            Console.Write("Enter a decimal value: ");
            d = float.Parse(Console.ReadLine());
            d = (float)Math.Sqrt(d + Math.Pow(d,2) + Math.Pow(d,3) + Math.Pow(d,10));
            Console.WriteLine("Result: " + d);

            
            
        }
    }
}
