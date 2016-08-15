using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("Please enter the salary: ");
            string salaryStr = Console.ReadLine();
            int intSalary;
            if (int.TryParse(salaryStr, out intSalary))
            {
                Console.WriteLine(CalculateIncome(intSalary));
            }
            else
            {
                Console.WriteLine("**Error**");
            }
        }

        public static string CalculateIncome(int intSalary)
        {
            //YOUR CODE HERE
            double income = 0;
            income = (intSalary + (intSalary * 0.1) + (intSalary * 0.03));
            return income.ToString("C2");
        }
    }
}
