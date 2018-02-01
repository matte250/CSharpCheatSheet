using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApplication
{
    class Person
    {
        /* Exercise 1.1 – Creating a class
         * Create a class that represents a person. Let the class hold information about the person first
         * name, last name and age. Let the constructor take in above data as parameters and create getonly
         * functionality. Write a method in the Program class that takes the person-datatype as a
         * parameter and print out the information about that person. Create a few person objects and pass
         * into the function.
         */
        string firstName, lastName;
        int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        /* Exercise 1.5 – Counting the number of Person-objects created
         * In this example, we are going to write the functionality for keeping count of the number of
         * person object created. Write a static integer variable in the person class, and write a static method
         * that increases this variable by one each time it’s called and one method that returns the current
         * value. Where could we call this method, so that it increases each time we create a new person?         */
        static int count;

        public static int Count
        {
            get
            {
                return count;
            }
        }

        public Person(string firstName, string lastName, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
            count += 1;
        }

        public Person()
        {
            lastName = "N/A";
            firstName = "N/A";
            age = 0;
            count += 1;
        }

        public void Speak()
        {
            /* Exercise 1.2 – Adding methods to the class
             * Add a method Speak that writes out “Hello my name is {first name} {last name}” to the
             * screen when calling it on a person object.
             */
        Console.WriteLine("Hello my name is {0} {1}.",firstName,lastName);
        }

        public override string ToString()
        {
            return firstName + lastName + age;
        }
    }
}
