using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersDrill
{
    public class OptionalParameters
    {
        public int PlusFourTimesOption (int num1, int num2 = 1)
        {
           int result = (num1 + 4) * num2;
            return result;
        }
       
    }
}
