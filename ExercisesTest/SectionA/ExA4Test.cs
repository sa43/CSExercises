using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExA4Test
    {
        [TestMethod]
        public void ExA4_SquareOf0()
        {
            double output = ExA4.square(0);
            Assert.AreEqual(0, output, "Square of 0 should be 0");
        }

        [TestMethod]
        public void ExA4_SquareOf10()
        {
            double output = ExA4.square(10);
            Assert.AreEqual(100, output, "Square of 10 should be 100");
        }

        [TestMethod]
        public void ExA4_SquareOfMin10()
        {
            double output = ExA4.square(-10);
            Assert.AreEqual(100, output, "Square of -10 should be 100");
        }

    }
}
