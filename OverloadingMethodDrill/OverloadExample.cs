using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDrill3
{
    public class OverloadExample
    {
        public int PlusThree (int num1)
        {
            int result = num1 + 3;
            return result;
        }
        public decimal PlusThree (decimal num1)
        {
            decimal result = Convert.ToInt32(num1 * 25);
            return result;
        }
        public int PlusThree (string value1)
        {
            int result = Convert.ToInt32(value1) / 10;
            return result;
        }
    }
}
