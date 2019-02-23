using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>() { 22, 44, 66, 12, 14, 10, 50 };
            //Console.WriteLine("Please enter a number to divide by.");
            //int numDiv = Convert.ToInt32(Console.ReadLine());

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number / numDiv);
            //    // when zero is chosen, a divide by zero exception error pops up. //
            //    // when a string is entered, a format exception error pops up. //
            //}
            //Console.ReadLine();

            List<int> numbers = new List<int>() { 22, 44, 66, 12, 14, 10, 50 };
            Console.WriteLine("Please enter a number to divide by.");

            try
            {
                foreach (int number in numbers)
                {

                    int numDiv = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(number / numDiv);
                    

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number, not a string.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please enter a number other than zero to divide by.");
            }
            Console.WriteLine("Program has emerged from Try/Catch block.");
            Console.ReadLine();
        }
    }
}
