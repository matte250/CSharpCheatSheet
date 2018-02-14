using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplication.Classes
{
    public class Student
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public int StudentId { get; private set; }

        static int amountOfStudents = 0;

        public Student()
        {
            // Set random values for construtctor.
            FirstName = RandomNames.FirstName();
            LastName = RandomNames.LastName();
            DateOfBirth = new DateTime(1954, 7, 30);
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;

            StudentId = amountOfStudents;
            amountOfStudents++;
        }

        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }

        public int GetAge()
        {
            TimeSpan ts = DateOfBirth - DateTime.Now;
            DateTime age = DateTime.MinValue + ts;
            return age.Year -1;
        }
    }
}
