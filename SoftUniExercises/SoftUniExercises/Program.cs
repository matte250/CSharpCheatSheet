using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUniExercises.Data;
using SoftUniExercises.Data.Models;

namespace SoftUniExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SoftUniContext())
            using (var dbTransaction = db.Database.BeginTransaction())
            {

                // Exercise 3
                //var query = db.Employees
                //    .OrderBy(e => e.EmployeeID)
                //    .Select(e => new
                //    {
                //        e.FirstName,
                //        e.LastName,
                //        e.MiddleName,
                //        e.JobTitle,
                //        e.Salary
                //    })
                //    ;

                //foreach (var i in query)
                //{
                //    Console.WriteLine(
                //        $"{i.FirstName} {i.LastName} {i.MiddleName} {i.JobTitle} {i.Salary:C}"
                //        );
                //}

                // Exercise 4
                //var query = db.Employees
                //    .OrderBy(e => e.FirstName)
                //    .Where(e => e.Salary > 50000)
                //    .Select(e => new
                //    {
                //        e.FirstName
                //    });

                //foreach(var i in query)
                //{
                //    Console.WriteLine($"{i.FirstName}");
                //}

                // Exercise 5
                //var query = db.Employees
                //    .Where(e => e.Department.Name == "Research and Development")
                //    .OrderBy(e => e.Salary)
                //    .Select(e => new
                //    {
                //        e.FirstName,
                //        e.LastName,                       
                //        e.Salary,
                //        DepartmentName = e.Department.Name
                //    });

                //foreach(var i in query)
                //{
                //    Console.WriteLine($"{i.FirstName} {i.LastName} from {i.DepartmentName} - {i.Salary:C}");
                //}

                // Exercise 6

                //var Address = new Address()
                //{
                //    AddressText = "Vitoshka 15",
                //    TownID = 4
                //};

                //db.Addresses.Add(Address);

                //var Employee = db.Employees.Single(e => e.LastName == "Nakov");
                //Employee.Address = Address;

                //db.SaveChanges();

                //var query = db.Employees
                //    .OrderByDescending(e => e.AddressID)
                //    .Take(10)
                //    .Select(e => new { AdressText = e.Address.AddressText, e.LastName });

                //foreach (var i in query)
                //{
                //    Console.WriteLine($"{i.AdressText} - {i.LastName}");
                //}

                // Exercise 7
                //db.Employees
                //    .Join(db.Employees,
                //    e => e.ManagerID,
                //    m => m.EmployeeID,
                //    (e, m) => new { Employees = e, Managers = m })
                //    .Where(e => e.Employees.Projects
                //    .Any(p => p.StartDate.Year >= 2001 && p.StartDate.Year <= 2003))
                //    .Take(30)
                //    .Select((e) => new
                //    {
                //        e.Employees.FirstName,
                //        e.Employees.LastName,
                //        ManagerFirstName = e.Managers.FirstName,
                //        ManagerLastName = e.Managers.LastName,
                //        e.Employees.Projects

                //    })
                //    .ToList()
                //     .ForEach(e => Console.WriteLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}{Environment.NewLine}" +
                //    $"{String.Join(Environment.NewLine, e.Projects.Select(p => $"--{p.Name} - {p.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - {(p.EndDate == null ? "not finished" : p.EndDate.ToString())}"))}"));

                //db.Employees
                //    .Join(db.Employees,
                //    e => e.ManagerID, 
                //    m => m.EmployeeID,
                //    (e, m) => new {Employees = e, Managers = m});

                // Exercise 8

                db.Addresses
                    .GroupBy(a => new {
                        a.AddressID,
                        a.AddressText,
                        a.Town.Name
                    },
                        (key, group) => new {
                            AddressText = key.AddressText,
                            Town = key.Name,
                            Count = group.Sum(a => a.Employees.Count)
                        })
                    .OrderByDescending(o => o.Count)
                    .ThenBy(o => o.Town)
                    .ThenBy(o => o.AddressText)
                    .Take(10)
                    .ToList()
                    .ForEach(o => Console.WriteLine($"{o.AddressText}, {o.Town} - {o.Count} employees"));

                dbTransaction.Rollback();
            }
        }
    }

}
