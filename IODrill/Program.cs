using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IODrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string number = string.Format(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Desktop\techacademy-projects\IODrill\log.txt", true))
            {
                file.WriteLine(number);
                
            }
            Console.WriteLine("The file reads: " + "\n" + File.ReadAllText(@"C:\Users\Student\Desktop\techacademy-projects\IODrill\log.txt"));
            Console.ReadLine();
        }
    }
}
