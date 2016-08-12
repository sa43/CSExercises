using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExB4Test
    {
        [TestMethod]
        public void ExB4_TestWithZero()
        {
            TestHelper.TestOutputContains(typeof(ExB4), "0\r\n", 32.ToString());
        }

        [TestMethod]
        public void ExB4_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestOutputContains(typeof(ExB4), n + "\r\n", (n * 1.8 + 32).ToString());
        }

        [TestMethod]
        public void ExB4_TestWithRandomNegativeNumber()
        {
            Random r = new Random();
            double n = r.Next(-100, -1);
            TestHelper.TestOutputContains(typeof(ExB4), n + "\r\n", (n * 1.8 + 32).ToString());
        }

    }
}
