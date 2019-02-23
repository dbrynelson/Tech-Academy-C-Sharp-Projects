using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParameters example1 = new OptionalParameters();

            Console.WriteLine("Please enter a number.");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If it pleases you, you have the option to enter another number. Or not...");
            if (Int32.TryParse(Console.ReadLine(), out int value3))
            {
                Console.WriteLine(example1.PlusFourTimesOption(value1, value3));

            }
            else
            {
                Console.WriteLine(example1.PlusFourTimesOption(value1));
            }


            Console.ReadLine();
        }

    }
}
