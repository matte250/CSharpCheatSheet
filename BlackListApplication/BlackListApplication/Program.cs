using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackListApplication
{
    class Program
    {

        static string[] blackListArray;
        static string[] messages;
        static int messageNumber;

        static void Main(string[] args)
        {
            /* (Exercise 42)
             * The company See sharp AB have discovered that the users on their forums use a very harsh language
             * when interacting with each other. So now they have asked you to write a swear word filter to censor these
             * occurring words. Before implementing this filter on their website, they want a demonstration in form of a
             * console program. 
             */

            blackListArray = new string[] {
                "fuck","shit","ernes","hästar"
            };
            messages = new string[100];
            messageNumber = 0;
            string str = "";
            while (!str.Equals("stop"))
            {
                Console.Clear();
                Console.WriteLine("Type \"stop\" to quit.\n");

                foreach(string s in messages)
                {
                    if (s != null) Console.WriteLine(s);
                }

                Console.Write("Input: ");
                str = Console.ReadLine();
                messages[messageNumber] = convertString(str);
                messageNumber++;
            }
            

        }

        static string convertString(string str)
        {
            foreach(string s in blackListArray)
            {
                while (str.ToLower().Contains(s))
                {
                    int index = str.ToLower().IndexOf(s);
                    str = str.Remove(index, s.Length);
                    str = str.Insert(index, String.Concat(Enumerable.Repeat("*", s.Length)));
                }
            }
            return str;
        }
    }
}
