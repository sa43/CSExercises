using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExC4Test
    {
        [TestMethod]
        public void ExC4_TestWithZero()
        {
            Assert.AreEqual(2.4,ExC4.CalculateFare(0));
            TestHelper.TestOutputEqual(typeof(ExC4), "0\r\n", "2.4");
        }

        [TestMethod]
        public void ExC4TestWithHalf()
        {
            Assert.AreEqual(2.4, ExC4.CalculateFare(0.5));
        }

        [TestMethod]
        public void ExC4Test9Km()
        {
            Assert.AreEqual(5.8, ExC4.CalculateFare(9));
            TestHelper.TestOutputEqual(typeof(ExC4), "9\r\n", (2.4 + 85 * 0.04).ToString());
        }

        [TestMethod]
        public void ExC4Test1213Km()
        {
            Assert.AreEqual(7.4, ExC4.CalculateFare(12.13));
        }
    }
}