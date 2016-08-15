using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the number: ");
            string inputString = Console.ReadLine();
            double inputDoubtle;
            if (Double.TryParse(inputString, out inputDoubtle))
                Console.WriteLine(SQRT(inputDoubtle));
            else
                Console.WriteLine("**Error**");
        }

        public static double SQRT(double x)
        {
            //YOUR CODE HERE: return the square root of x
            return Math.Sqrt(x);

        }
    }
}
