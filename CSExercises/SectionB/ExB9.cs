using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please enter the distance travelled (Kms) :");
            string stringDistance = Console.ReadLine();
            double doubleDistance;
            if (Double.TryParse(stringDistance, out doubleDistance))
                Console.WriteLine(RoundUpwardsTo10(CalculateFare(doubleDistance)));
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

        public static double RoundUpwardsTo10(double number)
        {
            return (Math.Ceiling(number * 10)) / 10;
        }
    }
}
