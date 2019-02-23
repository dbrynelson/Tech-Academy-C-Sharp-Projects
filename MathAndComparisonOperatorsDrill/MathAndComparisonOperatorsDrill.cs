using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            int product = num1 * 50;
            Console.WriteLine("Multiplied by 50 = " + product);
            

            Console.WriteLine("Please enter another number.");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);
            int total = num2 + 25;
            Console.WriteLine("Plus 25 = " + total);
            

            Console.WriteLine("Please enter a number.");
            string input3 = Console.ReadLine();
            int num3 = Convert.ToInt32(input3);
            double quotient = num3 / 12.5;
            Console.WriteLine("That number divided by 12.5 = " + quotient);

            Console.WriteLine("Please enter another number.");
            string input4 = Console.ReadLine();
            int num4 = Convert.ToInt32(input4);
            bool trueOrFalse = num4 > 50;
            Console.WriteLine("Is that number greater than 50? " + trueOrFalse);

            Console.WriteLine("Please enter one last number.");
            string input5 = Console.ReadLine();
            int num5 = Convert.ToInt32(input5);
            int remainder = num5 % 7;
            Console.WriteLine("That number divided by 7 has a remainder of... " + remainder);



            Console.ReadLine();



            


        }
    }
}
