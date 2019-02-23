using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDrill
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            string currentDay = Console.ReadLine();
           


            try
            {
                Enum.Parse(typeof(DaysOfTheWeek), currentDay);
                Console.WriteLine("Today is " + currentDay + ".");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);

            }

           

            Console.ReadLine();

        }



    
    }
    
}
