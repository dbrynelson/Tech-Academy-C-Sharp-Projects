using System;
using System.Collections.Generic;


namespace IterationDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////// drill 1////////////////////////

            //string[] names = { "Dane ", "Troy ", "Doug ", "Tom ", "Don " };
            //Console.WriteLine("Please enter some text to add");
            //string namesAdded = Console.ReadLine();

            //for (int j = 0; j < names.Length; j++)
            //{
            //    names[j] = names[j] + namesAdded;
            //    Console.WriteLine(names[j]);

            //}
            //Console.ReadLine();




            //string[] names = { "Dane ", "Troy ", "Doug ", "Tom ", "Don " };

            //string namesAdded = Console.ReadLine();


            /////////////////////// drill 2 - infinite loop ////////////////////////
            //for (; ; )
            //{
            //    Console.WriteLine(names[1]);
            //}
            //Console.ReadLine();

            ////////////////// drill 3 - fixed infinite loop ////////////////////////////

            //for (int j = 1; j <= 10; j++)
            //{
            //    Console.WriteLine(names[1]);
            //}
            //Console.ReadLine();

            //////////////// drill 4 ///////////////////////////////////////
            //int[] golfScores = { 55, 63, 81, 66, 72, 59 };

            //for (int i = 0; i < golfScores.Length; i++)
            //{
            //    if (golfScores[i] < 70)
            //    {
            //        Console.WriteLine("You shot a " + golfScores[i] + ", thats below par!");
            //    }
            //}

            //Console.ReadLine();

            ///////////////// drill 5 ////////////////////////////
            //for (int i = 0; i < golfScores.Length; i++)
            //{
            //    if (golfScores[i] <= 59)
            //    {
            //        Console.WriteLine("You shot a " + golfScores[i] + ", thats a new course record!");
            //    }
            //}
            //Console.ReadLine();

            /////////////// drill 6, 7, 8  ///////////////////////////

            //List<string> colors = new List<string>() { "blue", "green", "red", "yellow", "orange" };
            //Console.WriteLine("Please choose a color: blue, green, red, yellow, orange.");
            //string searchTerm = Console.ReadLine();
            //bool answer = false;

            //foreach (string color in colors)
            //{

            //    if (searchTerm == "blue")
            //    {
            //        Console.WriteLine(colors.IndexOf(searchTerm));
            //        break;
            //    }
            //    else if (searchTerm == "green")
            //    {
            //        Console.WriteLine(colors.IndexOf(searchTerm));
            //        break;

            //    }
            //    else if (searchTerm == "red")
            //    {
            //        Console.WriteLine(colors.IndexOf(searchTerm));
            //        break;

            //    }
            //    else if (searchTerm == "yellow")
            //    {
            //        Console.WriteLine(colors.IndexOf(searchTerm));
            //        break;

            //    }
            //    else if (searchTerm == "orange")
            //    {
            //        Console.WriteLine(colors.IndexOf(searchTerm));
            //        break;


            //    }
            //    else
            //    {
            //        Console.Write("Please try again.");
            //        Console.WriteLine("Please choose a color: blue, green, red, yellow, orange.");
            //        searchTerm = Console.ReadLine();

            //    }
            //}

            //Console.ReadLine();

            //////////// DRILL 9, 10 /////////////////////

            //List<string> colors = new List<string>() { "green", "blue", "blue", "yellow", "orange" };
            //Console.WriteLine("Please choose a color: blue, green, yellow, orange.");
            //string searchTerm = Console.ReadLine();
            //bool answer = false;


            //for (int j = 0; j < colors.Count; j++)
            //{
            //    if (searchTerm == colors[j])
            //    {
            //        Console.WriteLine(j);
            //        answer = true;

            //    }


            //}
            //if (answer == false)
            //{
            //    Console.WriteLine("Please try again.");



            //}


            ////////// DRILL 11 //////////////////////

            //List<string> colors = new List<string>() { "blue", "green", "blue", "yellow", "orange" };
            //List<string> hasAppeared = new List<string>();


            //foreach (string color in colors)
            //{

            //    if (!hasAppeared.Contains(color))
            //    {
            //        hasAppeared.Add(color);
            //        Console.WriteLine(color + " has not apeared");
            //    }
            //    else
            //    {
            //        Console.WriteLine(color + " has appeared.");
            //    }
            //}

            Console.ReadLine();
        }
    }
}
