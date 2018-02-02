using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SalesApplication
{
    class Program
    {
        const int MAX_EMPLOYES = 50;
        const int MAX_CLIENTS = 100;
        const double MAX_SALEVALUE = 1000;

        static Random r = new Random();

        static void Main(string[] args)
        {
            // Setting CultureInfo for currency reasons.
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            // List init.
            List<Employee> employeeList = new List<Employee>();

            // Fill list with random employes.
            for(int i = 0; i < MAX_EMPLOYES; i++)
            {
                employeeList.Add(new Employee(RandomNames.FirstName(), RandomNames.LastName(), r.Next(70)+10));
            }
            // Fill employees with random sales and clients.
            foreach(Employee e in employeeList)
            {
                int clientnumber = r.Next(MAX_CLIENTS-1)+1;
                for(int i = 0;i < clientnumber; i++)
                {
                    double salesnumber = r.NextDouble() * 1000;
                    Client c = new Client(RandomNames.FirstName(), RandomNames.LastName(), r.Next(70) + 10);
                    e.addSale(new Sales(RandomNames.ProductName(), salesnumber, c));
                }
            }
            //Output and formating

            foreach(Employee e in employeeList)
            {
                // First row.
                Console.Write("Employee - {0} {1}",e.FirstName,e.LastName);
                Console.CursorLeft = 31;
                Console.WriteLine("(Avg sale: {0:C})",e.GetAverageSaleAmount());
                // Second Row.
                Console.Write("[Number of sales: " + e.GetNumberOfSales());
                Console.CursorLeft = 29;
                Console.Write("Total gross: {0:C}",e.GetSalesTotal());
                Console.CursorLeft = 52;
                Console.WriteLine("]");
                // Individual sales.
                e.PrintSaleStatistics();

            }


            /* Exercise 1.3 & 1.4 – Printing the person class directly
             * Try using the Console.WriteLine to write out the person object to the screen by passing the
             * object as parameter.That is, Console.WriteLine(personObj ). What is the output?
             * 
             * Now, override the default ToString() method in the person class, and let it return the first
             * name, last name and age concatenated. Try calling the Console.WriteLine( personObj ) and see
             * what happens. What was the output?
             */
            
}

        static public void PrintPersonInfo(Person p)
        {
           
            Console.Write("Name: ");
            Console.Write(p.FirstName + " " + p.LastName);
            Console.CursorLeft = 32;
            Console.WriteLine("Age: " + p.Age);
        }
    }

   
}
