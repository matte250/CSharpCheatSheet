using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApplication
{
    class Program
    {
        static string[] stringDateArray;
        static int dateLength;
        static CultureInfo ci;


        static void Main(string[] args)
        {
            /*(Exercise 41)
             * Given strings in the following format “2014-01-22 12:00:00” and “2013-02-10 15:23:00, extract the date
             * part and display it in the following format: “22nd January 2014” and 10th February 2013”. Tip: use the Splitfunction.
             * Note, that this can be done using Date.DateParse, try doing it with string manipulation to practice.
             * When you done, try do it with DateTime.Parse to see the difference.
             */

            PrintExercise(41,"Dateformating.");

            ci = new CultureInfo("en-UK");
            stringDateArray = new string[100];
            dateLength = 0;

            AddFormatDate("2014 - 01 - 22 12:00:00");
            AddFormatDate("2013-02-10 15:23:00");
            AddFormatDate(DateTime.Now.ToString());

            foreach (string s in stringDateArray)
            {
                if (s != null) Console.WriteLine(s);
            }

        }

        public static void AddFormatDate(string date)
        {
            string day = DateTime.Parse(date).Day.ToString();
            string end = "";
            if (day.Length > 1)
            {
                day = day.Substring(1);
            }

            switch (day)
            {
                case "1":
                    end = "st";
                    break;
                case "2":
                    end = "nd";
                    break;
                case "3":
                    end = "rd";
                    break;
                default:
                    end = "th";
                    break;
            }

            day = DateTime.Parse(date).Day.ToString();

            stringDateArray[dateLength] = day + end + " " + DateTime.Parse(date).ToString("y", ci);
            dateLength++;

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
}
