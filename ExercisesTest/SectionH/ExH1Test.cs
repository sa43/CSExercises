using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExH1Test
    {
        [TestMethod]
        public void ExH1_TestOneChar()
        {
            bool found = ExH1.InString("The brown fox", "o");
            Debug.WriteLine("The brown fox, o");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void ExH1_TestPositive1()
        {
            bool found = ExH1.InString("The brown fox", "FOX");
            Debug.WriteLine("The brown fox, FOX");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void ExH1_TestPositive2()
        {
            bool found = ExH1.InString("The brown fox", "bRO");
            Debug.WriteLine("The brown fox, bRO");
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void ExH1_TestNegative1()
        {
            bool found = ExH1.InString("T", "bRO");
            Debug.WriteLine("T, FOX");
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ExH1_TestNegative2()
        {
            bool found = ExH1.InString("The bras basah complex", "bRO");
            Debug.WriteLine("The bras basah complex, bRO");
            Assert.IsFalse(found);
        }
    }
}