using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExB7Test
    {
        [TestMethod]
        public void ExB7_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(ExB7), "0\r\n", (2.40).ToString());
        }

        [TestMethod]
        public void ExB7_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                double n = r.Next(1, 100) + (r.Next(1, 3) * 0.01);
                TestHelper.TestOutputEqual(typeof(ExB7), n + "\r\n", (2.4 + n * 0.4).ToString());
            } 
        }

    }
}