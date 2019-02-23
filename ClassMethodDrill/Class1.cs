using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill
{
    class Class1
    {
        public void DivideTwo   (int num1)
        {
            int result = num1 / 2;
            Console.WriteLine(result);
        }

        public void getValues (out int value1, out int value2)
        {
            value1 = 10;
            value2 = 20;
        }

        public void DivideTwo (int num1, int num2)
        {
            int result = (num1 + num2) / 2;
            Console.WriteLine(result);
        }
    }
}
