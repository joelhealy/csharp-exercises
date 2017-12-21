/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 2 - Prep Exercise 2
 *
 *  Lists and Strings: Write a static method to print out each word in
 *  a list that has exactly 5 letters.
 *  
 */

using System;
using System.Collections.Generic;

namespace Class02PrepExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>
            {
                "fiver", "non-fiver", "print", "more than five",
                "metoo", "not me", "some other stuff"
            };
            ListHelper.PrintFives(myList);

            Console.ReadLine();
        }
    }
}
