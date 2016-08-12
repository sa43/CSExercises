using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExC5Test
    {
        [TestMethod]
        public void ExC5_TestWithAmstrongNumber()
        {
            TestHelper.TestOutputEqual(typeof(ExC5), "153\r\n", "Armstrong Number");
        }

        [TestMethod]
        public void ExC5_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                int n = r.Next(100, 999);
                if (n == 153 || n == 370 || n == 371 || n == 407)
                {
                    n = n + 1;
                }
                TestHelper.TestOutputEqual(typeof(ExC5), n + "\r\n", "Not Armstrong Number");
            }
        }

    }
}