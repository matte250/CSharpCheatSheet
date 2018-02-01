using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApplication
{
    class Client : Person
    {
        /* Exercise 1.6 – Inheritance
         * Write an employee class and a client class that are descendants of the person class.
         * Implement a salary property on the employee class and create a constructor that calls the base
         * person class constructor passing the information it needs. On both classes, override the ToString method
         * and let them return a distinct message depending whether they’re clients and employees.
         * Call the method you created in exercise 3 with both an employee and a client object.
         */

        public Client(string firstName, string lastName, int age) : base (firstName, lastName, age)
        {

        }

        public Client() : base()
        {

        }

        public override string ToString()
        {
            return "Client";
        }

    }
}
