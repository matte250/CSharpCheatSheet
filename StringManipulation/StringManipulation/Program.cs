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
            String str;
            // (Exercise 8) Manipulate a string with the phrase "The quick fox Jumped Over the DOG", so it prints out “The brown fox jumped over the lazy dog” litearly.
            // Use only methods provided in the String class.
            str = "The quick fox Jumped Over the DOG";
            str = str.Remove(4, 5);
            str = str.Insert(4, "brown");
            str = str.Insert(14,str.Substring(14).ToLower());
         
            str = str.Remove(14, 11);
            Console.WriteLine(str);
            

        }
    }
}
