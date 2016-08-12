using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExB2Test
    {
        [TestMethod]
        public void ExB2_TestWithZero()
        {
            Assert.AreEqual("0.000",ExB2.SQRT(0));
        }

        [TestMethod]
        public void ExB2_TestWithRandomNumber()
        {
            Assert.AreEqual("5.000", ExB2.SQRT(25));
            Assert.AreEqual("1.732", ExB2.SQRT(3));
            Assert.AreEqual("17.321", ExB2.SQRT(300));
        }

    }
}
