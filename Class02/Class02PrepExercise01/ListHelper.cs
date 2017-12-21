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
using System.Text;

namespace Class02PrepExercise01
{
    public class ListHelper
    {
        public static int SumOfEvens(List<int> listOfInt)
        {
            int sum = 0;
            foreach (int num in listOfInt)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
