using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please enter the distance travelled (Kms) :");
            string stringDistance = Console.ReadLine();
            double doubleDistance;
            if (Double.TryParse(stringDistance, out doubleDistance))
                Console.WriteLine(RoundTo10(CalculateFare(doubleDistance)));
            else
                Console.WriteLine("**Error**");
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE
            double minFare = 2.40;
            double farePerKM = 0.40;
            return minFare + distance * farePerKM;
        }

        public static double RoundTo10(double number)
        {
            return Math.Round(number, 1);
        }

    }
}
