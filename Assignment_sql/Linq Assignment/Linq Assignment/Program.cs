using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>
            {
               new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 8, 6), City = "Mumbai" },
               new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
               new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 12, 4), City = "Pune" },
               new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
               new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 8, 3), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
               new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 7, 11), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
               new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 2, 12), DOJ = new DateTime(2015, 1, 6), City = "Mumbai" },
               new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 6, 11), City = "Chennai" },
               new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 12, 8), DOJ = new DateTime(2014, 3, 12), City = "Chennai" },
               new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 2, 1), City = "Pune" }
            };

            //1.Display a list of all the employee who have joined before 1 / 1 / 2015

            Console.WriteLine("Employees who joined before 1/1/2015:");
            var before2015 = empList.Where(e => e.DOJ < new DateTime(2015, 1, 1));
            foreach (var emp in before2015)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.DOJ.ToShortDateString()}");
            }
            Console.WriteLine();

            //2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990

            Console.WriteLine("Employees whose data of birth is after 1/1/1990 :");
            var after1990 = empList.Where(e => e.DOB > new DateTime(1990, 1, 1));
            foreach (var emp in after1990)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.DOJ.ToShortDateString()}");
            }
            Console.WriteLine();

            //3.Display a list of all the employee whose designation is Consultant and Associate

            Console.WriteLine("Employees whose designation is Consultant and Associate");
            var desgEmp = empList.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            foreach (var emp in desgEmp)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName},{emp.Title}");
            }

            Console.WriteLine();

            //4.Display total number of employees

            Console.WriteLine($"Total number of Employees :  {empList.Count} ");
            Console.WriteLine();

            //5. Display total number of employees belonging to “Chennai”

            Console.WriteLine($"Total number of employees belonging to Chennai : {empList.Count(e => e.City == "Chennai")}");
            Console.WriteLine();

            //6. Display highest employee id from the list

            int maxEmployeeID = empList.Max(e => e.EmployeeID);
            Console.WriteLine($"Highest Employee ID: {maxEmployeeID}");
            Console.WriteLine();

            //7: Display total number of employees joined after 1/1/2015

            Console.WriteLine($"Total number of employees joined after 1/1/2015: {empList.Count(e => e.DOJ > new DateTime(2015, 1, 1))}");
            Console.WriteLine();

            //8. Display total number of employee whose designation is not “Associate”

            Console.WriteLine($"Total number of employees whose title is not 'Associate': {empList.Count(e => e.Title != "Associate")}");
            Console.WriteLine();

            //9. Display total number of employee based on City

            Console.WriteLine("Total number of employees based on City:");
            var cityCounts = empList.GroupBy(e => e.City)
                                   .Select(g => new { City = g.Key, Count = g.Count() });
            foreach (var city in cityCounts)
            {
                Console.WriteLine($"{city.City}: {city.Count}");
            }
            Console.WriteLine();

            // Task 10: Display total number of employees based on City and Title

            Console.WriteLine("Total number of employees based on City and Title:");
            var cityTitleCounts = empList.GroupBy(e => new { e.City, e.Title })
                                         .Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });
            foreach (var item in cityTitleCounts)
            {
                Console.WriteLine($"{item.City}, {item.Title}: {item.Count}");
            }
            Console.WriteLine();

            // Task 11: Display the youngest employee

            Console.WriteLine("Youngest Employee:");
            var youngestDOB = empList.Min(e => e.DOB);
            var youngestEmployee = empList.Where(e => e.DOB == youngestDOB);
            foreach (var emp in youngestEmployee)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, {emp.DOB.ToShortDateString()}");
            }

            Console.ReadLine();
        }
    }
}
}
