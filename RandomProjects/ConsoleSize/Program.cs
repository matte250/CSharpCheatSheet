using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Width: {0}\nHeight: {1}",Console.WindowWidth,Console.WindowHeight);
            Console.BackgroundColor = ConsoleColor.Blue;
            for(int i = 0; i < Console.WindowWidth; i++)
            {
                Console.CursorLeft = i;
                Console.Write("*");
            }
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.CursorTop = i;
                Console.CursorLeft = 0;
                Console.Write("*");
            }
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }
    }
}
