using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please enter side A: ");
            string sideA = Console.ReadLine();
            Console.Write("Please enter side B: ");
            string sideB = Console.ReadLine();
            Console.Write("Please enter side C: ");
            string sideC = Console.ReadLine();
            double doubleA, doubleB, doubleC;
            if ((double.TryParse(sideA, out doubleA) && double.TryParse(sideB, out doubleB) && double.TryParse(sideC, out doubleC))
                && CheckSideRule(doubleA, doubleB, doubleC))
            {
                Console.WriteLine(CalculateArea(doubleA, doubleB, doubleC));
            }
            else
                Console.WriteLine("NaN");
        }

        public static double CalculateArea(double a, double b, double c)
        {
            //YOUR CODE HERE
            double area;
            double semiperimeter = (a + b + c) / 2;
            area = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
            return area;
        }

        public static bool CheckSideRule(double a, double b, double c)
        {
            bool result = false;
            double semiperimeter = (a + b + c) / 2;
            if (semiperimeter >= a && semiperimeter >= b && semiperimeter >= c)
                result = true;
            return result;
        }
    }
}