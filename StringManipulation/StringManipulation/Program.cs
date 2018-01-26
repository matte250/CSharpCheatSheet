using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            String str, strTemp;
            // (Exercise 7) Manipulate a string with the phrase "The quick fox Jumped Over the DOG", so it prints out “The brown fox jumped over the lazy dog” litearly.
            // Use only methods provided in the String class.
            str = "The quick fox Jumped Over the DOG";

            str = str.ToLower();
            str = char.ToUpper(str[0]) + str.Substring(1);
            str = str.Remove(4, 5);
            str = str.Insert(4, "brown");
            str = str.Insert(30, "lazy ");
         
            Console.WriteLine(str);

            // (Exercise 8) Manipulate a string with the phrase "Arrays are very common in programming, they look something like: [1,2,3,4,5]", so it seperates the array
            // from the rest of the string. Then remove the numbers 2 and 3 while keeping the formating. Write the result.

            str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            str = str.Substring(str.IndexOf("["));
            str = str.Remove(3, 4);
            
            for(int i = 0; i < 5; i++)
            {
             
                    str = str.Insert(6 + (i * 2), "," + (6 + i).ToString());
               
            }

            Console.WriteLine(str);

            // (Exercise 9) Extract the four sets of parenteses in the pharse "(abc) and (cba) are each others reverse! Same goes for (bac) and (cab)!" and write them
            // to the console one line at the time.

            str = "(abc) and (cba) are each others reverse! Same goes for (bac) and (cab)!";
            strTemp = "";
            while (str.Contains("("))
            {
                str.IndexOf("(");
                strTemp += str.Substring(str.IndexOf("("), 5) + "\n";
                str = str.Substring(str.IndexOf("(") + 5);
            }
            
            Console.WriteLine(strTemp);



        }
    }
}
