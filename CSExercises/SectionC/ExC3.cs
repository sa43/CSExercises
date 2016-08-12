using System;

namespace CSExercises
{
    //3.	Write a program that would compute the grade for a mark that the student gets.  The program should take an integer number between 0 and 100 and print the following:
    //You scored 73 marks which is B grade.
    //where 73 is the input and B is calculated by the program.  Use the following table for computing the grades:

    //Marks         Grade
    //80 to 100	    A
    //60 to 79	    B
    //40 to 59	    C
    //0 to 40	    F
    //< 0  	        **Error**
    //> 100	        **Error**

    public class ExC3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            string grade = CalculateGrade(mark);
            Console.WriteLine("You scored {0} marks which is {1} grade.", grade);

        }

        public static string CalculateGrade(int mark)
        {
            //YOUR CODE HERE
            return null;
        }
    }
}