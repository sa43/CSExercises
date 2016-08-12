using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExC3Test
    {
        [TestMethod]
        public void ExC3_TestWithZero()
        {
            int grade = 0;
            Assert.AreEqual("F",ExC3.CalculateGrade(grade));
        }

        [TestMethod]
        public void ExC3_TestForA()
        {
            int grade = 80;
            Assert.AreEqual("A", ExC3.CalculateGrade(grade));
        }

        [TestMethod]
        public void ExC3_TestForB()
        {
            int grade = 60;
            Assert.AreEqual("B", ExC3.CalculateGrade(grade));
        }

        [TestMethod]
        public void ExC3_TestForC()
        {
            int grade = 40;
            Assert.AreEqual("C", ExC3.CalculateGrade(grade));
        }

        [TestMethod]
        public void ExC3_TestWithNegative()
        {
            Assert.AreEqual("**Error**", ExC3.CalculateGrade(-40));
        }

        [TestMethod]
        public void ExC3_TestWithLargeNumber()
        {
            Assert.AreEqual("**Error**", ExC3.CalculateGrade(-400));
        }
    }
}