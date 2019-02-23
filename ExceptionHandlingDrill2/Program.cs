using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill2
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            
            

            try
            {
                bool validAnswer = false;
                int age = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Please enter your age.");
                    validAnswer = int.TryParse(Console.ReadLine(), out age);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");

                }
                if (age <= 0)
                {
                    throw new Exception();
                }
                Console.WriteLine("You were born in the year " + (DateTime.Today.Year - age));
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred, please contact your System Administrator.");
                
            }
            

            Console.ReadLine();


        }
    }
}
