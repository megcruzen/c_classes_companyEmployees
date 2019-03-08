using System;
using System.Collections.Generic;

namespace companyEmployees
{
    public class Program
    {
        static void Main()
        {
            // Create an instance of a company. Name it whatever you like.
            Company acme = new Company("Acme", new DateTime(2001, 1, 1));


            // Create three employees
            Employee johnsmith = new Employee() {
                FirstName = "John",
                LastName = "Smith",
                Title = "CEO",
                StartDate = new DateTime(2001, 1, 1)
            };
            Employee janedoe = new Employee() {
                FirstName = "Jane",
                LastName = "Doe",
                Title = "Marketing Director",
                StartDate = new DateTime(2002, 2, 1)
            };
            Employee billjohnson = new Employee() {
                FirstName = "Bill",
                LastName = "Johnson",
                Title = "Marketing Director",
                StartDate = new DateTime(2006, 7, 10)
            };

            // Assign the employees to the company
            acme.EmployeeList.Add(johnsmith);
            acme.EmployeeList.Add(janedoe);
            acme.EmployeeList.Add(billjohnson);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            // foreach (Employee employee in acme.EmployeeList)
            // {
            //     Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {acme.Name} as {employee.Title} since {employee.StartDate}");
            // }

            acme.ListEmployees();

        }
    }
}
