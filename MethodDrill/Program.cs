using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill
{
   public class Program
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            //Class1 class1 = new Class1();

            total = Class1.Method1(num1);
            Console.WriteLine(total);
            Console.WriteLine(Class1.Method2(num1));
            Console.WriteLine(Class1.Method3(num1));
            Console.ReadLine();
        }
        
    }
    
}
