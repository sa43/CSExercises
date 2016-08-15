using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would convert temperature given in Centigrade 
    //scale to Fahrenheit – the number can be integer or real.  Use the formula:
    //	F = 1.8C  + 32

    public class ExB4
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please enter the temperature in centigrade scale : ");
            string stringCentigrade = Console.ReadLine();
            double doubleCentrigrade;
            if (Double.TryParse(stringCentigrade, out doubleCentrigrade))
                Console.WriteLine(ConvertToFahrenheit(doubleCentrigrade));
            else
                Console.WriteLine("**Error**");
        }

        public static double ConvertToFahrenheit(double c)
        {
            //YOUR CODE HERE - convert celcius to fahrenheit
            return ((1.8 * c) + 32);
        }
    }
}
