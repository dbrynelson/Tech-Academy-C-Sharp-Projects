using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Dane";
            string location = "Portland";
            string sport = "basketball";

            Console.WriteLine("Hi, my name is " + name + ", and I am from " + location + ".  I love to watch " + sport + ".");

            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();
            sb.Append("Dear Dane,");
            sb.Append("\n How are things going at the Tech Academy? ");
            sb.Append("I hope things are going well for you and that you're learning lots.\n  How much time before you finish boot camp?");
            sb.Append("I'm not sure that this is what the drill is asking me to do but I'm taking \n a stab at it anyways.");


            Console.WriteLine(sb);
            Console.ReadLine();




        }
    }
}
