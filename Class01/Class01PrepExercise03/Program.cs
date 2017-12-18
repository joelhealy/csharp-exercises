/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 1 - Prep Exercise 3
 *  
 *  Numeric types: Write a program that asks a user for the number of
 *  miles they have driven and the amount of gas they've consumed (in
 *  gallons), and print their miles-per-gallon.
 *  
 */
using System;

namespace Class01PrepExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of miles driven: ");
            string strMiles = Console.ReadLine();
            Console.Write("Enter the amount of gas consumed (in gallons): ");
            string strGasConsumed = Console.ReadLine();

            double miles = double.Parse(strMiles);
            double gasConsumed = double.Parse(strGasConsumed);
            double mpg = miles / gasConsumed;

            Console.WriteLine("\nCalculated Miles Per Gallon: " + mpg.ToString());
            Console.Write("\nPress <Enter> to continue");
            Console.ReadLine();
        }
    }
}
