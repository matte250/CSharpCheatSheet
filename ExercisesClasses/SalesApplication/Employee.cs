using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApplication
{
    class Employee : Person
    {
        /* Exercise 1.6 – Inheritance
         * Write an employee class and a client class that are descendants of the person class.
         * Implement a salary property on the employee class and create a constructor that calls the base
         * person class constructor passing the information it needs. On both classes, override the ToStringmethod
         * and let them return a distinct message depending whether they’re clients and employees.
         * Call the method you created in exercise 3 with both an employee and a client object.
         */

        public List<Sales> sales;
        private static string[] randomProductNames;
        private static string[] randomFirstNames;
        private static string[] randomLastNames;
        static Random r;

        public Employee(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            r = new Random();
            randomProductNames = new string[]
            {
                "Condoms", "Sack of potatoes", "Dank memes", "Fish", "Mullet", "Placenta", "Illegal software", "Drugs",
                "Air freshner", "Centaur", "Hat", "Husband pillow", "Girlfriend pillow", "Oni chan", "Afro", "Black tar heroin",
                "Dildo", "Dragons", "Cube", "Kinder eggs", "Skittles", "Fried chicken", "Waifu", "Mexicans", "Calories"
            };
            randomFirstNames = new string[]
            {
                "Bob","Mattias","Ernes","Philip","Filip","Memer"
            };


        }

        public Employee() : base()
        {
            r = new Random();
        }

        public override string ToString()
        {
            return base.ToString() + " is a Employee";
        }

        /* Exercise 1.8 – Calculating some sales statistics
         * Just storing each sales does not do us much good since the company is interested in how
         * many sales an employee has made and how much money he have earned for the company. Now,
         * they want you to create a few methods in the employee class that calculates these things. Let the
         * first method be GetNumberOfSales(), which returns the number of sales. Let the second method
         * be GetSalesTotal() that sums up the money sold for each element. Let the third method be to
         * calculate the average sale for the employee. Then lastly, create a method that prints out the sales
         * statistics for a specific employee.
         */

        public int GetNumberOfSales()
        {
            return sales.Count;
        }

        public double GetSalesTotal()
        {
            double sum = 0;
            foreach (Sales sale in sales)
            {
                sum += sale.SalesAmount;
            }

            return sum;
        }

        public double GetAverageSaleAmount()
        {
            double average = 0;
            if (sales.Count > 0) return GetSalesTotal() / GetNumberOfSales();
            return average;
        }

        public void PrintSaleStatistics()
        {

        }

        // Own code to add sales.
        public void addRandomSale()

        {
            int ri = r.Next(randomProductNames.Length);
            double rsa = r.NextDouble() * 1000;
            sales.Add(new Sales(randomProductNames[ri], rsa,))
        }
    }
}
