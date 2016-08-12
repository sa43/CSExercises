using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExC6Test
    {
        [TestMethod]
        public void ExC6_TestWithZero()
        {
            Assert.AreEqual(0,ExC6.CalculateTotalPrice(0, 0, 0));
        }

        [TestMethod]
        public void ExC6_TestWithOneProduct1()
        {
            Assert.AreEqual(4860, ExC6.CalculateTotalPrice(6, 0, 0));
        }

        [TestMethod]
        public void ExC6_TestWithOneProduct2()
        {
            Assert.AreEqual(5000, ExC6.CalculateTotalPrice(0, 10, 0));
        }

        [TestMethod]
        public void ExC6_TestWithOneProduct3()
        {
            Assert.AreEqual(4950, ExC6.CalculateTotalPrice(0, 11, 0));
        }

        [TestMethod]
        public void ExC6_TestWithOneProduct4()
        {
            Assert.AreEqual(9000, ExC6.CalculateTotalPrice(0, 20, 0));
        }

        [TestMethod]
        public void ExC6_TestWithOneProduct5()
        {
            Assert.AreEqual(5600, ExC6.CalculateTotalPrice(0, 0, 8));
        }

        [TestMethod]
        public void ExC6_TestWithTwoProducts1()
        {
            Assert.AreEqual(9265, ExC6.CalculateTotalPrice(1, 20, 0));
        }

        [TestMethod]
        public void ExC6_TestWithThreeProducts1()
        {
            Assert.AreEqual(11365, ExC6.CalculateTotalPrice(1, 20, 3));
        }
    }
}