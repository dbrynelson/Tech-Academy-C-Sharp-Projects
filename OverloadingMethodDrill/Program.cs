using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadExample example1 = new OverloadExample();
            OverloadExample example2 = new OverloadExample();
            OverloadExample example3 = new OverloadExample();
            
            Console.WriteLine(example1.PlusThree(12));
            Console.WriteLine(example2.PlusThree(1.25m));
            Console.WriteLine(example3.PlusThree("100"));
            Console.ReadLine();
        }
    }
}
