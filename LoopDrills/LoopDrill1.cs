using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color?");
            string favColor = Console.ReadLine();
            bool isGuessed = favColor == "green";


            do
            {
                switch (favColor)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");

                        Console.WriteLine("Guess my favorite color?");
                        favColor = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess my favorite color?");
                        favColor = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess my favorite color?");
                        favColor = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guesseed green! That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("That is not my favorite color.");
                        Console.WriteLine("Guess my favorite color?");
                        favColor = Console.ReadLine();
                        break;

                }
            }
            while (!isGuessed);


            Console.ReadLine();

        }
    }
}
