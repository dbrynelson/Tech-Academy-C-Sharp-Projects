using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> name = new Employee<string>();
            name.Things = new List<string>() { "Jesse", "Bart", "Randy", "Tim", "Steve" };

            Employee<int> age = new Employee<int>();
            age.Things = new List<int>() { 30, 44, 52, 32, 50 };
             

            foreach (string person in name.Things)
            {
                Console.WriteLine(person);
            }
            foreach (int empAge in age.Things)
            {
                Console.WriteLine(empAge);
            }

            Console.ReadLine();



        }
    }
}
