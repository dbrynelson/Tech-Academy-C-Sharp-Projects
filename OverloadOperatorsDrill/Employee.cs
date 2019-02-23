using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorDrill
{
    public class Employee
    {
        public int iD { get; set; }

        public Employee()
        {
            iD = 0;
        }
        public Employee(int employeeId)
        {
            iD = employeeId;
        }

        public static bool operator == (Employee employee1, Employee employee2)
        {
            if (employee1.iD == employee2.iD)
                return true;
            else
                return false;
        }

        public static bool operator != (Employee employee1, Employee employee2)
        {
            if (employee1.iD != employee2.iD)
                return true;
            else
                return false;
        }
        public int getValue()
        {
            return iD;
        }
       

    }
}
