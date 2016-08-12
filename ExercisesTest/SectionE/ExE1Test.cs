using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExE1Test
    {
        [TestMethod]
        public void ExE1_TestSimpleNumber()
        {
            Assert.AreEqual(120, ExE1.CalculateFactorialInc(5));
            Assert.AreEqual(120, ExE1.CalculateFactorialDec(5));
        }

        [TestMethod]
        public void ExE1_TestBiggerNumber()
        {
            Assert.AreEqual(720, ExE1.CalculateFactorialInc(6));
            Assert.AreEqual(720, ExE1.CalculateFactorialDec(6));
        }
    }
}