using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesDrill
{
    public class Program
    {
        static void Main(string[] args)
        {
            NewUser newUser = new NewUser("Dane");

            const string sayHi = "Hello";
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("{0} {1}! Thanks for signing up with us, as a promotional bonus we're giving you ${2}.", sayHi, name, newUser.SignUpPromo);


            Console.ReadLine();
        }
    }
}
