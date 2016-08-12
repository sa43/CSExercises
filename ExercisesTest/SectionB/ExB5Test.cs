using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExB5Test
    {
        [TestMethod]
        public void ExB5_TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(ExB5), "0\r\n", 3.ToString());
        }

        [TestMethod]
        public void ExB5_TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestOutputEqual(typeof(ExB5), n + "\r\n", (2 * n * n - 4 * n + 3).ToString());
        }

        [TestMethod]
        public void ExB5_TestWithRandomNegativeNumber()
        {
            Random r = new Random();
            double n = r.Next(-100, -1);
            TestHelper.TestOutputEqual(typeof(ExB5), n + "\r\n", (2 * n * n - 4 * n + 3).ToString());
        }

    }
}
