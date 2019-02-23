using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number should I pick for my basketball jersey?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (favNum)
                {
                    case 21:
                        Console.WriteLine("You suggested 21, I don't want to wear that number. How about another?");
                        Console.WriteLine("What number should I pick for my basketball jersey?");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You suggested 12, I don't want to wear that number. How about another?");
                        Console.WriteLine("What number should I pick for my basketball jersey?");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You suggested 7, I don't want to wear that number. How about another?");
                        Console.WriteLine("What number should I pick for my basketball jersey?");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Yeah! 3 is a great pick! I'll choose this for my jersey");
                        isGuessed = true;                        
                        break;
                    default:
                        Console.WriteLine("Nah, I don't like that number.");
                        Console.WriteLine("What number should I pick for my basketball jersey?");
                        favNum = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
