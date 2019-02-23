using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int drivingAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Please answer 'true' or 'false'");
            bool haveDUI = true;
            string dui = Convert.ToString(haveDUI);
            Console.ReadLine();


            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int speedTix = Convert.ToInt32(tickets);

            bool ageLimit = drivingAge > 15;
            bool speedingTix = speedTix < 3;
            bool isInsured = ageLimit && haveDUI && speedingTix;
     





            Console.WriteLine("Do you qualify for insurance? " + isInsured);
            Console.ReadLine();
        }
    }
}
