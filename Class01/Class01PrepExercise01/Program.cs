/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 1 - Prep Exercise 1
 *  
 *  Input/output: Modify your HelloWorld program to prompt the user for
 *  their name, and greet them by name.using System;
 *  
 */

using System;

namespace Class01PrepExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string username = Console.ReadLine();
            Console.WriteLine("Hello, " + username + "!");
            Console.WriteLine("\nPress <Enter> to continue");
            Console.ReadLine();
        }
    }
}
