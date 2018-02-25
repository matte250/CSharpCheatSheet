using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[]{ "lol" };
            Testing(a);
            Console.WriteLine(a[0]);
        }

        static void Testing(string[] ab)
        {
            ab[0] = "memer";
        }
    }
}
