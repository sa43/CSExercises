using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExB3Test
    {
        [TestMethod]
        public void ExB3_TestWithZero()
        {
            TestHelper.TestOutputContains(typeof(ExB3), "0\r\n", String.Format("{0:c}", 0));
        }

        [TestMethod]
        public void ExB3_TestWithRandomNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestOutputContains(typeof(ExB3), n + "\r\n", String.Format("{0:c}", n * 1.13));
        }

    }
}
