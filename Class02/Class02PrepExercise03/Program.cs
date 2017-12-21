/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 2 - Prep Exercise 3
 *
 *  Arrays:  Create and initialize in a single line an array with the
 *  following values: 1, 1, 2, 3, 5, 8. Then loop through the array
 *  and print out each value.
 *  
 */

using System;

namespace Class02PrepExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
