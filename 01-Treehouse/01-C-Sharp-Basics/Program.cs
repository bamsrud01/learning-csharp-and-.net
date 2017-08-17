using System;           //  Can type Console.Write() rather than System.Console.Write() as long as all classes do not have others with the same names in other namespaces

namespace Treehouse
{
    class Program
    {
        static void Main()
        {
            int runningTotal = 0;                                      //  Variables in C# have types
            //  Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");   //  Displays text to user
            string entry = Console.ReadLine();                         //  Read and return user input until they press return key
            //  Add minutes exercised to total
            int minutes = int.Parse(entry);
            runningTotal = runningTotal + minutes;
            //  Display total minutes exercised to screen
            Console.WriteLine("You've exercised " + entry + " minutes!");
            //  Repeat until user quits
        }
    }
}



//  Compiling and running in Workspaces
    //  To compile: mcs Program.cs
    //  To run:     mono Program.exe
