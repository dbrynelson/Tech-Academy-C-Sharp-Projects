using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate for Person 1?");
            string hourlyRate1 = Console.ReadLine();
            int num1 = Convert.ToInt32(hourlyRate1);
            Console.WriteLine("Hours worked per week by Person 1?");
            string workHours1 = Console.ReadLine();
            int num2 = Convert.ToInt32(workHours1);


            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate for Person 2?");
            string hourlyRate2 = Console.ReadLine();
            int num3 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week by Person 2?");
            string workHours2 = Console.ReadLine();
            int num4 = Convert.ToInt32(workHours2);

            int product1 = num1 * num2;
            Console.WriteLine("Weekly salary of Person 1 = " + product1);
            int product2 = num3 * num4;
            Console.WriteLine("Weekly salary of Person 2 = " + product2);
            bool trueOrFalse = product1 > product2;
            Console.WriteLine("Does Person 1 make more than Person 2?  " + trueOrFalse);

            Console.ReadLine();





        }
    }
}
