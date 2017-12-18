/*
 * LaunchCode 101 - Unit 3: CSharp
 * 
 * Class 1 Prep Exercise 2
 * 
 * Numeric types: Write a program to calculate the area of a rectangle 
 * and print the answer to the console. You should prompt the user for
 * the dimensions. (What data types should the dimensions be?)
 * 
 */

using System;

namespace Class01PrepExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This progam will calculate the area of a rectangle");
            Console.Write("\nEnter the length of the rectangle: ");
            string strLength = Console.ReadLine();
            Console.Write("\nEnter the width of the rectangle: ");
            string strWidth = Console.ReadLine();

            double length = double.Parse(strLength);
            double width = double.Parse(strWidth);
            double area = length * width;

            Console.WriteLine("\nCalculated area of rectangle: " + area.ToString());
            Console.Write("\nPress <Enter> to continue");
            Console.ReadLine();
        }
    }
}
