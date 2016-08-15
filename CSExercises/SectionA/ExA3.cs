using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that will takes an integer as input and prints the square of that number
    //For this exercise, the input and output has been implemented for you in the template
    //You need to implement the square function

    public class ExA3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the integer number: ");
            string inputString = Console.ReadLine();
            int inputInt;
            if (int.TryParse(inputString, out inputInt))
                Console.WriteLine(square(inputInt));
            else
                Console.WriteLine("**Error**");

        }

        public static int square(int x)
        {
            //PUT YOUR CODE HERE
            return x * x;

        }
    }
}
