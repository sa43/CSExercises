using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExD2Test
    {
        [TestMethod]
        public void ExD2_TestWithPositiveNumber1()
        {
            int hcf = 0;int lcm = 0;
            ExD2.CalculateHCFAndLCM(8, 4, ref hcf, ref lcm);
            Assert.AreEqual(4, hcf);
            Assert.AreEqual(8, lcm);
        }

        [TestMethod]
        public void ExD2_TestWithPositiveNumber2()
        {
            int hcf = 0; int lcm = 0;
            ExD2.CalculateHCFAndLCM(120, 2000, ref hcf, ref lcm);
            Assert.AreEqual(40, hcf);
            Assert.AreEqual(6000, lcm);
        }

    }
}