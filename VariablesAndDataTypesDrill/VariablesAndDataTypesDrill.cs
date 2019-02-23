using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main()
        {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        
        Console.WriteLine("What course are you on?");
        string courseProgram = Console.ReadLine();

        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageNumber);

        Console.WriteLine("Do you need help with anything? Answer 'true' or 'false'");
        bool needHelp = true;
        string helpPlz = Convert.ToString(needHelp);
        Console.ReadLine();


        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string sharedExp = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        int studyHours = Convert.ToInt32(hoursStudied);

        Console.WriteLine("Thank you for your answers. An Instructor will respiond to this shortly. Have a great day!");
        Console.ReadLine();


    }
    }

