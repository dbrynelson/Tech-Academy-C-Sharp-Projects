using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class //
            Class1 object1 = new Class1();
            int value1, value2;

            Console.WriteLine("Enter a number.");

            int input1 = Convert.ToInt32(Console.ReadLine());
            object1.DivideTwo(input1);


            object1.getValues(out value1, out value2);

            // overload method //
            Console.WriteLine("Please enter a second number:");
            int input2 = Convert.ToInt32(Console.ReadLine());
            object1.DivideTwo(input1, input2);
            
            // output parameters //
            Console.WriteLine("Value1: {0}", value1);
            Console.WriteLine("Value2: {0}", value2);

            // static class //
            Console.WriteLine(StaticClass.addFour(input1));
            

            Console.ReadLine();
        }
    }
}
