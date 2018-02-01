using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApplication
{
    class Sales
    {
        /* Exercise 1.7 – Creating a sales class
         * In this exercise we want to create a class that hold a sale transaction that an employee
         * makes with a client. The sales class should contain a name of the product sold, the money sold for
         * in dollars (double), and a client class that references a client. Also, create a DateTime property that
         * hold the information about when the sale was made. Let the employee class hold a collection of
         * sales objects and implement a method that adds a new sales to the list. Also, create a constructor
         * that instantiates the sales object. The date of the sale can be created in the constructor as the
         * current date (DateTime.Now).
         */

        DateTime timeSold;

        public string Name
        {
            get;set;
        }

        public double SalesAmount
        {
            get;set;
        }

        public Client ClientSoldTo
        {
            get;set;
        }

        public DateTime TimeSold
        {
            get
            {
                return timeSold;
            }
        }

        public Sales()
        {
            timeSold = DateTime.Now;

        }

        public Sales(string name, double salesAmount, Client clientSoldTo)
        {
            timeSold = DateTime.Now;
            Name = name;
            SalesAmount = salesAmount;
            ClientSoldTo = clientSoldTo;
        }

    }
}
