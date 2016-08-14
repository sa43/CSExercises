using System;

namespace CSExercises
{
    //Write a program that would request for your name, 
    //gender and age and would print a greeting like this:
    //Good morning Uncle Sam( if Sam, M, 45 is entered)
    //(any gentlemen 40 years or more is Uncle any lady 
    //40 years or more is Aunty, if less than forty they 
    //become just Mr or Ms. as the case may be.)


    public class ExC2
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //YOUR CODE HERE
            string salutation = GetSalutation(gender, age);
            Console.WriteLine("{0} {1} {2}", "Good Morning", salutation, name);
        }

        private static string GetSalutation(string gender, int age)
        {
            string salutation = string.Empty;
            if (gender.ToUpper() == "M")
            {
                if (age >= 40)
                    salutation = "Uncle";
                else
                    salutation = "Mr.";
            }
            else if (gender.ToUpper() == "F")
            {
                if (age >= 40)
                    salutation = "Aunty";
                else
                    salutation = "Ms.";
            }
            return salutation;
        }
    }
}