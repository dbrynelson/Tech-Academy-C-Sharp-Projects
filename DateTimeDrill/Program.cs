using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeDrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is: " + DateTime.Now);
            Console.WriteLine("Please enter a number.");
            int hoursAdded = Convert.ToInt32(Console.ReadLine());
            DateTime futureTime = DateTime.Now.AddHours(hoursAdded);
            Console.WriteLine("In {0} hours...it will be {1}", hoursAdded, futureTime); 
            
            Console.ReadLine();
        }
    }
}
