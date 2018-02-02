using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }

        }
    }
}
