using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (Exercise 43)
             * Given the string “[ { fruit:pear , colour:green }, { fruit:orange, colour: orange },{ fruit:apple, colour : red
             * }]”, extract the fruits and their colour and display it to the user like: “The fruit pear is green”
             */

            int arrayLength = 0;
            string[] fruitsAndColors = new string[100];
            string str = "[ { fruit: pear , colour: green }, { fruit: orange, colour: orange },{" +
                "fruit: apple, colour: red }]";
            str = str.Replace("[ ", "");
            str = str.Replace("]", "");
            str = str.Replace(" ", "");
            Console.WriteLine(str);
            while (str.Contains("{"))
            {
                fruitsAndColors[arrayLength] = str.Substring(0, str.IndexOf("}")).Replace("{","");
                str = str.Remove(0, 1);
                if(str.Contains("{")) str = str.Remove(0, str.IndexOf("{"));
                arrayLength++;
            }

            foreach(string s in fruitsAndColors)
            {
                if (s != null)
                {
                    string fruit = s.Remove(s.IndexOf(","));
                    fruit = fruit.Substring(fruit.IndexOf(":")+1);
                    string color = s.Remove(0, s.IndexOf(",colour:")+8);
                    Console.WriteLine("The fruit {0} is {1}",fruit,color);
                }
            }
                                           


        }
    }
}
