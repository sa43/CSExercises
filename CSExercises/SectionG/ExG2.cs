using System;

namespace CSExercises
{
    //Write a C# program to determine if a given string is a palindrome.
    //    a.Your program should take a string from the console and test if the word is a palindrome or not using the approach explained by your instructor(you are expected to follow the steps given by the instructor)
    //–	A palindrome is a word/phrase that reads the same forwards or backwards.
    //–	Examples: ABBA, 747, radar, madam

    //b.	Modify the above program to accommodate sentences which may have upper case letters, punctuation or space that may need to be ignored while doing the test.
    //–	Examples:
    //A Santa at NASA
    //Mr.Owl ate my metal worm

    public class ExG2
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            if (IsPalindrome(phrase))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        public static bool IsPalindrome(string phrase)
        {
            //YOUR CODE HERE
            return false;




        }
    }
}
