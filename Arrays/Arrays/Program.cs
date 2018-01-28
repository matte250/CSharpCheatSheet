using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Random r = new Random();

            /* (Exercise 33 & Exercise 34)
             * Initiate two arrays, one with integer values, and one with strings. Fill the first one with a couple of
             * numbers, and the second one with names. Tip: use the list initialiser
             * 
             * Loop through the arrays from the previous exercise and print the content to the console window. For the
             * names, write every second name with upper case.
             */

            PrintExerciseExtra(33, 34, "Simple Arrays");

            int[] intArray = { 0, 2, 3, 4, 5, 2, 3, 4, 2, 5 };
            string[] strArray = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < strArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(strArray[i].ToUpper());
                }
                else
                {
                    Console.WriteLine(strArray[i]);
                }
            }

            Console.ReadKey();

            /* (Exercise 35-38)
             * Ask the user for a number. Use the number to generate an array with the length of the number. Loop
             * through the array and generate a random number on each position. Tip: Use the Random-class
             * 
             * Create an array with arbitrary size and fill with random numbers like the previous exercise. Then create
             * a new array with the same size and copy over the values to it.
             * 
             * Create two arrays with arbitrary sizes and fill them with random numbers. Then make a new array with
             * the combined size of the two previous arrays and copy the values into it.             *              * Create two arrays with arbitrary sizes and fill them with random numbers. Then copy over the numbers
             * so that the even numbers are located in the rear (the right side) part of the array and the odd numbers are
             * located in the front part (the left side).             */

            PrintExerciseExtra(35, 37, "Array input, copying, sorting and randomizer.");            Console.Write("Enter value: ");            x = Int32.Parse(Console.ReadLine());            int[] randomArrayA = new int[x];
            int[] randomArrayB = new int[x];
            int[] randomArrayC = new int[x * 2];
            int[] tempArray = new int[x * 2];
            int iterationsEven = 0, iterationsOdd = 0;

            Console.WriteLine("Array A");

            for (int i = 0; i < x; i++)
            {
                randomArrayA[i] = r.Next(99);
                Console.WriteLine(randomArrayA[i]);
            }            Console.WriteLine("Array B");            for (int i = 0; i < x; i++)
            {
                randomArrayB[i] = r.Next(99);
                Console.WriteLine(randomArrayB[i]);
            }            Console.WriteLine("Array C");            randomArrayA.CopyTo(randomArrayC, 0);            randomArrayB.CopyTo(randomArrayC, x);

            for (int i = 0; i < x * 2; i++)
            {
                Console.WriteLine(randomArrayC[i]);
            }            Console.WriteLine("Array sorted");

            for (int i = 0; i < x * 2; i++)
            {
                if (randomArrayC[i] % 2 == 0)
                {
                    iterationsEven++;
                    tempArray[(x * 2) - iterationsEven] = randomArrayC[i];
                }
                else
                {
                    tempArray[iterationsOdd] = randomArrayC[i];
                    iterationsOdd++;
                }
            }            for (int i = 0; i < x * 2; i++)
            {
                Console.WriteLine(tempArray[i]);
            }            Console.ReadKey();
            /* (Exercise 39)
             * Create two arrays with equal sizes. One should contain username and one should contain passwords.
             * Let the user try to input a username and a password and match it against the arrays. If he types in a correct
             * username and password, display a secret message to him. (You can assume that username on position n
             * belongs to password on position n in respective array)
             */

            PrintExercise(39, "Usernames and passwords.");

            string[] usernames =
            {
                "user1","user2","user3","user4","somebodytouchamy"
            };

            string[] passwords =
            {
                "pass1","pass2","pass3","pass4","spaghet"
            };

            string[] secrets =
            {
                "Hello user1! :)","Hello user2! :P","Hello user3! :3","Hello user4! :D","BUT CAN YOU DO THIS!? __o "
            };

            Console.WriteLine(
                "USERNAMES\n" +
                "user1, user2, user3, user4, somebodytouchamy\n" +
                "Hint: The password is for each username is just passX, where x is the users number.\n");
            Console.Write("Enter username: ");
            string user = Console.ReadLine();
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            if (usernames.Contains(user)&&passwords.Contains(pass))
            {
                for(int i = 0; i < usernames.Length; i++)
                {
                    if (user.Equals(usernames[i]) && pass.Equals(passwords[i]))
                    {
                        Console.WriteLine(secrets[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nThe username or password is wrong.");
            }

            Console.ReadKey();

            /* (Exercise 40)
             * Let the user input a string with numbers comma separated like “1,2,34,83,19,45” then separate the
             * numbers into an array and find the min, max and average value. Print these out to the screen. Tip: use the Splitfunction.             */

            PrintExercise(40, "String manipulation into arrays.");            Console.WriteLine("Example string: 2,4,5,9,3,8,4");            Console.Write("Enter string:");

            int min = int.MaxValue, max = int.MinValue, average = 0;            string[] strNumberArray = Console.ReadLine().Split(',');            foreach (string s in strNumberArray)
            {

                Int32.TryParse(s);
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

        public static void PrintExerciseExtra(int x,int y, string desc)
        {
            // Printing format for exercise descriptions.
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("(Exercise {0}-{1}) ", x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(desc);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(String.Concat(Enumerable.Repeat("- ", 20)));
        }
    }
}
