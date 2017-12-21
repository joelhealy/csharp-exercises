/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 2 - Prep Exercise 1
 *
 *  Lists:  Write a static method to find the sum of all the even
 *  numbers in a list.  Within Main, create a list with at least 10
 *  integers and call your method on the list.
 *  
 */

using System;
using System.Collections.Generic;

namespace Class02PrepExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>
            {
                1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            };
            int sumOfEvens = ListHelper.SumOfEvens(myList);
            Console.WriteLine("The sum of the even numbers in myList is " +
                sumOfEvens);

            Console.ReadLine();
        }
    }
}
