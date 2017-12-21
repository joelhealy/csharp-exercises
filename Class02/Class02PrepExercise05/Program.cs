/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 2 - Prep Exercise 5
 *
 *  Strings:  In one of the Gradebook programs (it doesn't matter which),
 *  modify the code that prints out the class roster near the end of the
 *  program to use the StringBuilder class.
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class02PrepExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print roster
            Console.WriteLine("\nClass roster:");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < students.Count; i++)
            {
                sb.AppendLine(students[i] + " (" + grades[i] + ")");
            }
            Console.WriteLine(sb);

            double sum = grades.Sum();
            double avg = sum / grades.Count;
            Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}
