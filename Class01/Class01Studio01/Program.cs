/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 1 - Studio 1
 *  
 *  Write a program/class Area that prompts the user for a number
 *  representing the radius, and then calculates the area of a 
 *  circle with that radius and prints the result.
 *  
 *  
 *  Bonus Missions:
 *  
 *  1.  Add validation to your program. If the user enters a negative
 *  number, print an error message and quit. You'll need to peek ahead
 *  to learn about conditional syntax in C#.
 *
 *  2.  Extend your program further by using a while or do-while loop,
 *  so that when the user enters a negative number they are re-prompted.
 *  
 */

using System;

namespace Class01Studio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a radius: ");
            string strRadius = Console.ReadLine();

            double radius = double.Parse(strRadius);

            while (radius < 0)
            {
                Console.WriteLine("This program cannot calculate " +
                    "areas for circles with negative radii.\n");
                
                Console.Write("Enter a non-negative radius: ");
                strRadius = Console.ReadLine();

                radius = double.Parse(strRadius);
            }
            double area = 3.14 * radius * radius;

            Console.WriteLine("The area of a circle with radius " +
                strRadius + " is: " + area.ToString());

            Console.Write("\nPress <Enter> to continue");
            Console.ReadLine();


        }
    }
}
