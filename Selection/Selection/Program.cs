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
            String str, strTemp = "";
            int temp;
            
            // (Exercise 12) Ask the user to input a name. If the name is Bob or Alice, then display "Hi Bob!" or "Hi Alice!".

            Console.Write("Enter name: ");
            str = Console.ReadLine().ToLower();
            if (str.Contains("bob")) Console.WriteLine("Hi Bob!");
            if (str.Contains("alice")) Console.WriteLine("Hi Alice!");

            // (Exercise 13) Ask the user to input a number. If that number is divesible by 4, then display the result.

            Console.Write("Enter a number divisible by 4: ");
            temp = Int32.Parse(Console.ReadLine());
            if (temp % 4 == 0)
            {
                Console.WriteLine(temp / 4);
            }
            else
            {
                Console.WriteLine("Your number isnt divisble by 4.");
            }

            // (Exercise 14) Ask the user to input some text. If that text includes the word "city", then display at what position the word
            // occures in the text.

            temp = 0;
            Console.Write("Write any sentence: ");
            str = Console.ReadLine().ToLower();
            
            if (str.Contains("city"))
            {
                while (str.Contains("city"))
                {
                    strTemp += str.IndexOf("city") + ",";             
                    str = str.Substring(0,str.IndexOf("city")+4).Replace("city","null") + str.Substring(str.IndexOf("city") + 4);
                }

                strTemp = strTemp.Remove(strTemp.LastIndexOf(","));

                if (strTemp.Contains(","))
                {
                    Console.WriteLine("The word city occurces at positions " + strTemp + ".");
                }
                else
                {
                    Console.WriteLine("The word city occures at position " + strTemp + ".");
                }
            }
            else
            {
                Console.WriteLine("Your sentence has no occurences of the word \"city\".");
            }
       

            // (Exercise 15) Ask the user to input some text. Check if the length of the text excedes 25 characters.
            // Display result.

            Console.Write("Input text: ");
            str = Console.ReadLine();
            if (str.Length > 25)
                Console.WriteLine("Your input excedes 25 characters.");
            else
                Console.WriteLine("Your input does not excede 25 characters.");
           

            // (Exercise 16) Display three different options for the user to choose from. Clear the console then display a different
            // message deepending on the option. Display also a message if the choice is invalid.

            Console.WriteLine("Input one of these following options.\n" +
                "1. Option 1\n" +
                "2. Option 2\n" +
                "3. Option 3");
            Console.Write("Input numerical: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("This is option 1! :)");
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("This is option 2! :3");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("This is option 3! :D");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option! :C");
                    break;

            }
            

            // (Exercise 17) Ask the user to input two intergers A and B. Then show results of A+B, A*B, A/B.
            // Dont let user divide by zero.

            Console.Write("Input value A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Input value B: ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Results\n" +
                "A + B = " + (a+b) + "\n" +
                "A * B = " + (a*b));
            if (b != 0)
            {
                Console.WriteLine("A / B = " + ((double)a/b));
            }
            else
            {
                Console.WriteLine("A / B = N/A(Cant divide by 0)");
            }

            

            // (Exercise 18) Ask the user to input a number, then check if the number is higher or equal than 10 and less or equal than 20.
            // Display the result.

            Console.Write("Input value: ");
            temp = Int32.Parse(Console.ReadLine());
            if (temp <= 20 && temp >= 10)
            {
                Console.WriteLine("Value is in range between 10 and 20." );
            }else if(temp < 10)
            {
                Console.WriteLine("Value is less than 10.");
            }
            else
            {
                Console.WriteLine("Value is higher than 20.");
            }
            

            // (Exercise 19) Ask the user to input a color, then do a switch statent to see if that color exists. If it does, change the
            // console color and print a message of the color.

            Console.Write("Write the name of a color: ");
            str = Console.ReadLine();

            switch (str.ToLower())
            {
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "dark blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dark green":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "dark red":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dark magenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "dark yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "dark gray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("Invalid color name!");
                    break;
                   
            }

            Console.WriteLine(Console.ForegroundColor.ToString().ToUpper() + "!");
            Console.ForegroundColor = ConsoleColor.Gray;


        }
    }
}
