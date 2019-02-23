using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(12345);
            Employee employee2 = new Employee(67890);

            if (employee1 == employee2)
                Console.WriteLine("Same Employee");
            else
                Console.WriteLine("Different Employees");



            Console.ReadLine();

            
        }
    }
}
