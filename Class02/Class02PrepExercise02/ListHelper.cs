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
    public class ListHelper
    {
        public static void PrintFives(List<string> listOfString)
        {
            foreach (string str in listOfString)
            {
                if (str.Length == 5)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
