using System;           //  Can type Console.Write() rather than System.Console.Write() as long as all classes do not have others with the same names in other namespaces

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            double runningTotal = 0.0;                                      //  Variables in C# have types, but 'var' can sometimes be used to declare.  Types are determined when compiled regardless
            //  In this case, we cannot use 'var' with 0 as 0 is not necessarily a double.  It could be an int.  So we add a decimal value to force it to be a double

            while(true)
            {
                //  Prompt the user for minutes exercised
                Console.WriteLine("Enter how many minutes you exercised, or type 'quit' to exit: ");
                var entry = Console.ReadLine();                         //  Read and return user input until they press return key

                if (entry.ToLower()g == "quit")
                {
                    break;
                }

                //  Add minutes exercised to total
                try
                {
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value");
                        continue;     //  Instructs loop to start again from the beginning
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Good start!");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Now you're just showing off!");
                    }
                    else
                    {
                        Console.WriteLine("Great job!  Make sure you take a break!");
                    }

                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.Write("That is not valid input");
                    continue;
                }

                //  Display total minutes exercised to screen
                Console.WriteLine("You've exercised " + runningTotal + " minutes!");
            }
            Console.WriteLine("Goodbye!");
        }
    }
}



//  Compiling and running in Workspaces
    //  To compile: mcs Program.cs
    //  To run:     mono Program.exe
