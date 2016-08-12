using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExB1Test
    {
        [TestMethod]
        public void ExB1_TestWithZero()
        {
            Assert.AreEqual(0, ExB1.SQRT(0), 0.00001);
        }

        [TestMethod]
        public void ExB1_TestWithRandomNumber()
        {
            Random r = new Random();
            double n = Math.Round(r.NextDouble()*100,5);
            Assert.AreEqual(Math.Sqrt(n), ExB1.SQRT(n), 0.00001);
        }

    }
}
