using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDrill
{
    public class Employee : Person
    {
        public virtual void SayName()
        {
            string fullName = FirstName + LastName;
            Console.WriteLine("Name: " + fullName);
            
        }

    }
}

