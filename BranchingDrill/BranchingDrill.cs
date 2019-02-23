using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight: ");
            decimal packWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package width: ");
            decimal packWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package height: ");
            decimal packHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter package length: ");
            decimal packLength = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
            }
            else if (packHeight + packLength + packWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                decimal sum = packHeight + packLength + packWidth;
                decimal quote = (sum * packWeight) / 100;
                decimal priceQuote = Math.Round(quote, 2);
                string total = priceQuote.ToString("C");
                Console.WriteLine("Your estimated total for shipping this package is: " + total);
            }
           


            Console.ReadLine();
        }
    }
}
