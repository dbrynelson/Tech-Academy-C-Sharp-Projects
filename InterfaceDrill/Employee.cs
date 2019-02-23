using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDrill
{
    public class Employee : Person, IQuittable
    {
        public virtual void SayName()
        {
            string fullName = FirstName + LastName;
            Console.WriteLine("Name: " + fullName);
            
        }

        public void Quit()
        {
            Console.WriteLine("Player " + FirstName + " has quit the game.");
            Console.ReadLine();
        }
        
    }
}

