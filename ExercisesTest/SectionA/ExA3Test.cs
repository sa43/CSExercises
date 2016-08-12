using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExA3Test
    {
        [TestMethod]
        public void ExA3_SquareOf0()
        {
            int output = ExA3.square(0);
            Assert.AreEqual(0, output,"Square of 0 should be 0");
        }

        [TestMethod]
        public void ExA3_SquareOf10()
        {
            int output = ExA3.square(10);
            Assert.AreEqual(100, output, "Square of 10 should be 100");
        }

        [TestMethod]
        public void ExA3_SquareOfMin10()
        {
            int output = ExA3.square(-10);
            Assert.AreEqual(100, output, "Square of -10 should be 100");
        }
    }
}
