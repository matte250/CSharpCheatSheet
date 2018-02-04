using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraugeParking
{
    class Program
    {

        static void Main(string[] args)
        {
            // Initiazing array.
            string[] parkingArray = new string[100];
            for (int i = 0; i < 100; i++) parkingArray[i] = "";
            char menu = '!';

            // Menu code.
            while (menu != 'x')
            {
                Console.Clear();
                Console.CursorVisible = false;
                Console.WriteLine("PRAUGE PARKING");
                printState(parkingArray);
                Console.WriteLine("A to add car. B to add MC. C to remove vehicles. X to exit program.");
                menu = Console.ReadKey().KeyChar;
                if (menu == 'a')
                {
                    // Adding car.
                    Console.CursorVisible = true;
                    Console.CursorLeft = 0;
                    Console.Write("Input reg: ");
                    addVehicle(ref parkingArray, Console.ReadLine());
                    menu = '!';
                }
                if (menu == 'b')
                {
                    // Adding MC.
                    Console.CursorVisible = true;
                    Console.CursorLeft = 0;
                    Console.Write("Input reg: ");
                    addVehicle(ref parkingArray, Console.ReadLine() + ":");

                    menu = '!';
                }
                if (menu == 'c')
                {
                    // Removing vehicle.
                    Console.CursorVisible = true;
                    Console.CursorLeft = 0;
                    Console.Write("Input reg: ");
                    removeVehicle(ref parkingArray, Console.ReadLine());
                    sortVehicles(ref parkingArray);
                    menu = '!';
                }
            }

        }

        static int searchVehicle(ref string[] a, string reg)
        {
            for(int i = 0;i < a.Length; i++)
            {
                // Loop thru parking to find reg. Cars
                if(a[i].Contains)    
            }
        }

        static void addVehicle(ref string[] a, string reg)
        {

            if (!reg.Contains(":"))
            {
                // If vehicle is a car.
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i].Equals(""))
                    {
                        a[i] = reg;
                        break;
                    }
                }
            } else if (reg.Contains(":")) 
            {
                // If vehicle is a MC.
            }
        }

        static void removeVehicle(ref string[] a, string reg)
        {
            for(int i = 0; i < a.Length; i++)
            {
                // Check if ref exists in parking.
                if (a[i].Contains(reg))
                {
                    // Check to see if whole ref is true.
                    if (a[i].Equals(reg))
                    {
                        // Make spot empty.
                        a[i] = "";
                    }
                }
            }
        }

        static void sortVehicles(ref string[] a)
        {

        }

        static void printState(string[] a)
        {
            int index = 0;
            for(int i = 0; i < 20; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.CursorLeft = x * 20;
                    if (index < 9) Console.Write(" ");
                    if (index < 99) Console.Write(" ");
                    if(!a[index].Equals("")) Console.Write("{0}: {1}", index+1, a[index]);
                    if (a[index].Equals("")) Console.Write("{0}: [Spot Empty]", index+1);
                    index++;

                }
                Console.WriteLine();
            }
        }
    }
}
