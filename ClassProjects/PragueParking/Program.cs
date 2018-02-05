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
        PrintState(parkingLot);

    }

    static void AddVehicle(ref string[] a, string reg)
    {

    }

    static void RemoveVehicle(ref string[] a, string reg)
    {

    }

    static int SearchVehicle(string[] a)
    {
        return 0;
    }

    static void MoveVehicle(ref string[] a, int from, int to)
    {

    }

    static void MoveVehicle(ref string[] a, string reg, int to)
    {

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

