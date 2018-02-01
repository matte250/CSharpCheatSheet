using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Client("Ernes", "Filipovic", 25);
            Person person2 = new Employee("Mattias", "Soroccos", 21);
            Person person3 = new Person("Paul", "Kulberg", 12);
            PrintPersonInfo(person1);
            PrintPersonInfo(person2);
            PrintPersonInfo(person3);

            /* Exercise 1.3 & 1.4 – Printing the person class directly
             * Try using the Console.WriteLine to write out the person object to the screen by passing the
             * object as parameter.That is, Console.WriteLine(personObj ). What is the output?
             * 
             * Now, override the default ToString() method in the person class, and let it return the first
             * name, last name and age concatenated. Try calling the Console.WriteLine( personObj ) and see
             * what happens. What was the output?
             */

            Console.WriteLine(person1);
            
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
