using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionDrill
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public int Id;

        public Employee(string name1, string name2, int empId)
        {
            FirstName = name1;
            LastName = name2;
            Id = empId;
        }

        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee("Joe", "Smith", 1));
            employeeList.Add(new Employee("Bob", "Brown", 2));
            employeeList.Add(new Employee("Mike", "Jordan", 3));
            employeeList.Add(new Employee("Steve", "Austin", 4));
            employeeList.Add(new Employee("Joe", "Dirt", 5));
            employeeList.Add(new Employee("Daivd", "Hassleoff", 6));
            employeeList.Add(new Employee("Allen", "Iverson", 7));
            employeeList.Add(new Employee("Bart", "Simpson", 8));
            employeeList.Add(new Employee("Michael", "Meyers", 9));
            employeeList.Add(new Employee("Randy", "Marsh", 10));


            //foreach (Employee employee in employeeList)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName + " Employee Id: " + employee.Id);
            //    }
            //}

            //List<Employee> newList = employeeList.Where(x => x.FirstName == "Joe").ToList();

            //foreach (Employee employee in newList)
            //{
            //    Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName + " Employee Id: " + employee.Id);
            //}

            List<Employee> newList = employeeList.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in newList)
            {
                Console.WriteLine("Name: " + employee.FirstName + " " + employee.LastName + " Employee Id: " + employee.Id);
            }


            Console.ReadLine();


        }
    }
}
