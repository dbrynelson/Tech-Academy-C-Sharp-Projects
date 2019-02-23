using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another value.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Class1 object1 = new Class1();
            object1.addTwo(num1: num1, num2: num2);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
