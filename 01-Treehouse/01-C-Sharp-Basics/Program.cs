using System;     //  Can type Console.Write() rather than System.Console.Write() as long as all classes do not have others with the same names in other namespaces

namespace Treehouse.FitnessFrog
{
    class Program
    {
        static void Main()
        {
            //  Prompt the user for minutes exercised
            Console.Write("Enter how many minutes you exercised: ");   //  Displays text to user
            string entry = Console.ReadLine();                         //  Read and return user input until they press return key
            //  Add minutes exercised to total
            //  Display total minutes exercised to screen
            //  Repeat until user quits
        }
    }
}



//  Compiling and running in Workspaces
    //  To compile: mcs Program.cs
    //  To run:     mono Program.exe
