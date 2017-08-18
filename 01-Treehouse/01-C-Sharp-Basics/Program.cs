using System;           //  Can type Console.Write() rather than System.Console.Write() as long as all classes do not have others with the same names in other namespaces

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;                                      //  Variables in C# have types
            bool keepGoing = true;

            while(keepGoing)
            {
                //  Prompt the user for minutes exercised
                Console.WriteLine("Enter how many minutes you exercised, or type 'quit' to exit: ");
                string entry = Console.ReadLine();                         //  Read and return user input until they press return key

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    //  Add minutes exercised to total
                    try
                    {
                        int minutes = int.Parse(entry);

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

                        runningTotal = runningTotal + minutes;
                    }
                    catch (FormatException)
                    {
                        Console.Write("That is not valid input");
                        continue;
                    }

                    //  Display total minutes exercised to screen
                    Console.WriteLine("You've exercised " + runningTotal + " minutes!");
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}



//  Compiling and running in Workspaces
    //  To compile: mcs Program.cs
    //  To run:     mono Program.exe
