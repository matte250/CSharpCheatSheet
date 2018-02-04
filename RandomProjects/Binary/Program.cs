using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 2;
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
        }
    }
}
