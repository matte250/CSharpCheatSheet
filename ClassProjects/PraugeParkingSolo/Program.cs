using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] parkingLot = new string[100];
        for (int i = 0; i < 100; i++) parkingLot[i] = "";
        SeedArray(ref parkingLot);
        testMenu(ref parkingLot);

    }

    static void testMenu(ref string[] a)
    {
        char menu = '!';
        do
        {
            // Menu start.
            Console.CursorVisible = false;
            Console.Beep();
            Console.Clear();
            // Print menu.
            PrintState(a);
            Console.WriteLine("\n1. Add car, 2. Add MC, 3. Remove Vehicle, 4. Move Vehicle, 5. Search Vehicle.");
            // Option selction.
            menu = Console.ReadKey().KeyChar;
            Console.CursorLeft = 0;
            if (menu.Equals('1'))
            {
                // Add car.
                Console.Write("Input reg#: ");
                string s = Console.ReadLine();
                if (!s.Contains(":") && s.Length < 10 && SearchVehicle(a, s) == -1)
                {
                    // If input is legal.
                    AddVehicle(ref a, s);
                }
                else
                {
                    Console.WriteLine("Illegal input, make sure there is no colon(:) in your string," +
                        " and that it does not contain more than 10 characters." +
                        "\n Also make sure that your input does not already exist in the array.");
                    Console.ReadKey();
                }
            }
            if (menu.Equals('2'))
            {
                // Add MC.
                Console.Write("Input reg#: ");
                string s = Console.ReadLine();
                if (!s.Contains(":") && s.Length < 10 && SearchVehicle(a, s) == -1)
                {
                    // If input is legal.
                    AddVehicle(ref a, s + ":");
                }
                else
                {
                    Console.WriteLine("Illegal input, make sure there is no colon(:) in your string," +
                        " and that it does not contain more than 10 characters." +
                        "\n Also make sure that your input does not already exist in the array.");
                    Console.ReadKey();
                }
            }
            if (menu.Equals('3'))
            {
                // Remove Vehicle.
                Console.Write("Input reg#: ");
                string s = Console.ReadLine();
                if (!s.Contains(":") && s.Length < 10 && SearchVehicle(a, s) != -1)
                {
                    // If input is legal.
                    RemoveVehicle(ref a, s );
                }
                else
                {
                    Console.WriteLine("Illegal input, make sure there is no colon(:) in your string," +
                        " and that it does not contain more than 10 characters." +
                        "\n Also make sure that your input does exist in the array.");
                    Console.ReadKey();
                }
            }
            if (menu.Equals('4'))
            {
                // Move Vehicle.
                Console.Write("Input reg#: ");
                string s = Console.ReadLine();
                if (!s.Contains(":") && s.Length < 10 && SearchVehicle(a, s) != -1)
                {
                    // If input is legal.
                    int sn;
                    Console.Write("Enter parking spot: ");
                    if (Int32.TryParse(Console.ReadLine(), out sn) && sn <= 100 && sn >= 1)
                    {
                        // If second input is legal.
                        MoveVehicle(ref a, s, sn-1);
                    }
                    else
                    {
                        // If second input is not legal.
                        Console.WriteLine("Illegal input, make sure that your input only contains numbers," +
                        " and that it does not exced the value of 100.");
                        Console.ReadKey();
                    }                        
                }
                else
                {
                    Console.WriteLine("Illegal input, make sure there is no colon(:) in your string," +
                        " and that it does not contain more than 10 characters." +
                        "\n Also make sure that your input does exist in the array.");
                    Console.ReadKey();
                }
            }
            if (menu.Equals('5'))
            {
                // Remove Vehicle.
                Console.Write("Input reg#: ");
                string s = Console.ReadLine();
                if (!s.Contains(":") && s.Length < 10 && SearchVehicle(a, s) != -1)
                {
                    // If input is legal.
                    int result = SearchVehicle(a, s);
                    if(result != -1)
                    {
                        Console.WriteLine("Your vehicle({0}) can be found at parking spot {1}.", s, result+1);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("{0} does not exist.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Illegal input, make sure there is no colon(:) in your string," +
                        " and that it does not contain more than 10 characters." +
                        "\n Also make sure that your input does exist in the array.");
                    Console.ReadKey();
                }
            }


        } while (!menu.Equals('x'));

    }

    static void AddVehicle(ref string[] a, string reg)
    {
        if (reg.Contains(":"))
        {
            // If input reg is a MC.
            bool b = false;
            for (int i = 0; i < a.Length; i++)
            {
                // Look for MCs standing alone.
                if (a[i].EndsWith(":"))
                {
                    // If a MC is standing alone at current iteration.
                    a[i] = a[i] + reg.Replace(":", "");
                    b = true;
                    break;
                }
            }

            if (b==false)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    // If no MC was found alone, put at empty place.
                    if (a[i].Equals(""))
                    {
                        a[i] = reg;
                        break;
                    }

                }
            }

        }
        else
        {
            // If input reg is a car.
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(""))
                {
                    a[i] = reg;
                    break;
                }
            }
        }
    }

    static void RemoveVehicle(ref string[] a, string reg)
    {
        int regIndex = SearchVehicle(a, reg);
        if (regIndex != -1)
        {
            // If reg exists.
            if (a[regIndex].Contains(":"))
            {
                // If reg index contains MC.
                if (a[regIndex].EndsWith(":"))
                {
                    // If MC is alone.
                    a[regIndex] = ""; // Make space free.
                }
                else
                {
                    // If MC is not alone.
                    if (a[regIndex].Substring(0, a[regIndex].IndexOf(":")).Equals(reg))
                    {
                        // If MC reg is located before the colon.
                        a[regIndex] = a[regIndex].Substring(a[regIndex].IndexOf(":") + 1) + ":";
                    }
                    else
                    {
                        // If im reg is located after the colon.
                        a[regIndex] = a[regIndex].Substring(0, a[regIndex].IndexOf(":")+1);
                    }
                }
            }
        }
    }

    static int SearchVehicle(string[] a, string reg)
    {
        for (int i = 0; i < a.Length; i++)
        {
            // Loop thru array.
            if (a[i].Contains(":"))
            {
                // If current position contains atleast one MC.
                if (a[i].EndsWith(":"))
                {
                    // If current position only contains one MC.
                    if (a[i].Replace(":", "").Equals(reg)) return i;
                }
                else
                {
                    // If current position contains two MCs.
                    if (a[i].Substring(0, a[i].IndexOf(":")).Equals(reg) || a[i].Substring(a[i].IndexOf(":") + 1).Equals(reg)) return i;
                }
            }
            if (a[i].Equals(reg)) return i; // If reg is a car.
        }
        return -1;
    }

    static void MoveVehicle(ref string[] a, int from, int to)
    {
        // Switch contents of index from and to in ref array a.
        string temp = a[to];
        a[to] = a[from];
        a[from] = temp;
    }

    static void MoveVehicle(ref string[] a, string reg, int to)
    {
        int regIndex = SearchVehicle(a, reg);
        if (regIndex != -1)
        {
            // If reg exists.
            if (!a[to].Contains(":") || !a[regIndex].Contains(":"))
            {
                // If index to or reg contains a car.
                string temp = a[to];
                a[to] = a[regIndex];
                a[regIndex] = temp;
            }
            else if (a[to].Contains(":"))
            {
                //If atlest one MC exists at index to.
                if (a[to].EndsWith(":"))
                {
                    // If index to contains only one MC.
                    if (a[regIndex].EndsWith(":"))
                    {
                        // If index of reg contains only one MC.
                        a[to] = a[to] + a[regIndex].Replace(":", "");
                        a[regIndex] = "";
                    }
                    else
                    {
                        // If index of reg contains more than one MC.
                        if (a[regIndex].Substring(0, a[regIndex].IndexOf(":")).Equals(reg))
                        {
                            // If reg is before colon at reg index.
                            a[to] = a[to] + a[regIndex].Substring(0, a[regIndex].IndexOf(":"));
                            a[regIndex] = a[regIndex].Substring(a[regIndex].IndexOf(":") + 1) + ":";
                        }
                        else
                        {
                            // If reg is after colon at reg index.
                            a[to] = a[to] + a[regIndex].Substring(a[regIndex].IndexOf(":") + 1);
                            a[regIndex] = a[regIndex].Substring(0, a[regIndex].IndexOf(":"));
                        }
                    }
                }
                else
                {
                    // If index to contains two MCs
                    string temp = a[to];
                    a[to] = a[regIndex];
                    a[regIndex] = temp;
                }
            }
        }

    }

    static void CompressMCs(ref string[] a)
    {

    }

    static void SeedArray(ref string[] a)
    {
        Random rd = new Random(DateTime.Now.Millisecond);
        int index = rd.Next(0, 100);


        for (int i = 0; i < 4; i++)
        {
            if (a[index].Equals(""))
            {
                a[index] = CreateVehicle(rd);
                index = rd.Next(0, 100);
            }
            else
                i--;
        }

        for (int i = 0; i < 4; i++)
        {
            index = rd.Next(0, 100);
            if (a[index].Equals(""))
            {
                a[index] = CreateVehicle(rd) + ":";
                index = rd.Next(0, 100);
            }
            else
            {
                i--;
            }
        }

        for (int i = 0; i < 4; i++)
        {
            index = rd.Next(0, 100);
            if (a[index].Equals(""))
            {
                a[index] = CreateVehicle(rd) + ":" + CreateVehicle(rd);
                index = rd.Next(0, 100);
            }
            else
            {
                i--;
            }
        }
    }

    static string CreateVehicle(Random r)
    {
        string vehicle = "";
        char c;

        for (int i = 0; i < 3; i++)
        {
            c = (char)(r.Next(65, 90));
            vehicle = vehicle.Insert(vehicle.Length, c.ToString());
        }
        for (int i = 0; i < 3; i++)
        {
            c = (char)r.Next(48, 57);
            vehicle = vehicle.Insert(vehicle.Length, c.ToString());
        }

        return vehicle;
    }

    static void PrintState(string[] a)
    {
        int index = 0;
        for (int i = 0; i < 20; i++)
        {
            for (int x = 0; x < 5; x++)
            {
                Console.CursorLeft = x * 20;
                if (index < 9) Console.Write(" ");
                if (index < 99) Console.Write(" ");
                if (!a[index].Equals("")) Console.Write("{0}: {1}", index + 1, a[index]);
                if (a[index].Equals("")) Console.Write("{0}: [Spot Empty]", index + 1);
                index++;

            }
            Console.WriteLine();
        }
    }



}

