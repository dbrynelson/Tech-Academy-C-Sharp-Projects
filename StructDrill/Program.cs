using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill
{
    class Program
    {
        public struct Number
        {
            public decimal Amount { get; set; }


        }
        static void Main(string[] args)
        {
            Number num1 = new Number();
            num1.Amount = 5;

            Console.WriteLine("num1: {0}", num1.Amount);
            Console.ReadLine();
        }
    }
}
