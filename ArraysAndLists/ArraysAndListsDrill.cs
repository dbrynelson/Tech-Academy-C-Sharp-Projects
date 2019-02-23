using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {

        string[] stringArray = { "red", "blue", "green", "yellow", "orange" };
        bool guessIndex = false;
        while (guessIndex == false)
        {

            Console.WriteLine("Please select an index. Select a number between 0 and 4.");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            if (stringIndex > 4)
            {
                Console.WriteLine("That number is not between 0 and 4. Please try again.");


            }
            else
            {
                Console.WriteLine("The value of the index is: " + stringArray[stringIndex]);
                guessIndex = true;
            }

        }


        int[] numArray = { 3, 5, 7, 9, 21 };
        bool guessIndex2 = false;

        while (guessIndex2 == false)
        {

            Console.WriteLine("Please select an index. Select a number between 0 and 4.");
            int numIndex = Convert.ToInt32(Console.ReadLine());

            if (numIndex > 4)
            {
                Console.WriteLine("That number is not between 0 and 4. Please try again.");


            }
            else
            {
                Console.WriteLine("The value of the index is: " + numArray[numIndex]);
                guessIndex2 = true;
            }

        }

        List<string> stringList = new List<string> { "Dane", "Troy", "Keith", "Marcus", "Larry" };
        bool guessedIndex3 = false;

        while (guessedIndex3 == false)
        {
            Console.WriteLine("Please select an index number between 0 and 4.");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            if (listIndex > 4)
            {
                Console.WriteLine("That number is not between 0 and 4. Please try again.");

            }
            else
            {
                Console.WriteLine("The value of the index is: " + stringList[listIndex]);
                guessedIndex3 = true;

            }
        }

        Console.ReadLine();

        }
    }

