/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 2 - Prep Exercise 4
 *
 *  Dictionaries:  Make a program similar to GradebookDict, but which
 *  takes in students names and ID numbers (as integers) instead of
 *  names and grades. In this case, however, the keys should be integers
 *  (the IDs) and the values should be strings (the names). Modify the
 *  roster printing code accordingly.
 *  
 */

using System;
using System.Collections.Generic;

namespace Class02PrepExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = 
                new Dictionary<int, string>();

            string studentID;
            string studentName;

            do
            {
                Console.Write("\nEnter new student ID (or <Enter> to finish>): ");
                studentID = Console.ReadLine();

                if (studentID.Length > 0)
                {
                    Console.Write("Enter new student name: ");
                    studentName = Console.ReadLine();

                    students.Add(int.Parse(studentID), studentName);
                }
            }
            while (studentID.Length > 0);

            // Print the roster
            Console.WriteLine("\nClass Roster");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(String.Format("{0}: {1}", student.Key, student.Value));
            }

            Console.ReadLine();

        }
    }
}
