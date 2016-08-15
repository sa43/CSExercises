using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the x1 coordinate :");
            string stringX1 = Console.ReadLine();
            Console.Write("Please enter the y1 coordinate :");
            string stringY1 = Console.ReadLine();
            Console.Write("Please enter the x2 coordinate :");
            string stringX2 = Console.ReadLine();
            Console.Write("Please enter the y2 coordinate :");
            string stringY2 = Console.ReadLine();
            double x1, x2, y1, y2;
            if (Double.TryParse(stringX1, out x1) && Double.TryParse(stringX2, out x2) && Double.TryParse(stringY1, out y1) && Double.TryParse(stringY2, out y2))
            {
                //Console.WriteLine("Distance: {0}", CalculateDistance(x1, y1, x2, y2));
                Console.WriteLine(CalculateDistance(x1, y1, x2, y2));
            }
            else
                Console.WriteLine("**Error**");
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            //YOUR CODE HERE
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
