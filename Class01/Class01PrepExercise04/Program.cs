/*  
 *  LaunchCode 101 - Unit 3: CSharp
 *  
 *  Class 1 - Prep Exercise 4
 *  
 *  Strings: The first sentence of Alice's Adventures in Wonderland is
 *  below. Store this sentence in a string, and then prompt the user
 *  for a string to search for within this string. Print whether or not
 *  the search term was found. See if you can make the search case-
 *  insensitive, so that searching for "alice" prints true. 
 *  
 *  Alice was beginning to get very tired of sitting by her sister on
 *  the bank, and of having nothing to do: once or twice she had peeped
 *  into the book her sister was reading, but it had no pictures or 
 *  conversations in it, 'and what is the use of a book,' thought Alice 
 *  'without pictures or conversation?'
 *
 */
using System;

namespace Class01PrepExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLineAlice = @"
Alice was beginning to get very tired of sitting by her sister on the 
bank, and of having nothing to do: once or twice she had peeped into 
the book her sister was reading, but it had no pictures or conversations 
in it, 'and what is the use of a book,' thought Alice 'without pictures 
or conversation?'".Replace(Environment.NewLine, "");
            string firstLineAliceLC = firstLineAlice.ToLower();

            Console.Write("Enter a string to search for: ");
            string searchTerm = Console.ReadLine();

            bool stringFound = firstLineAliceLC.Contains(searchTerm.ToLower());
            Console.WriteLine("\nSearch term found: " + stringFound.ToString());
            Console.Write("\nPress <Enter> to continue");
            Console.ReadLine();
        }
    }
}
