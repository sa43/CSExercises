using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExH2Test
    {
        [TestMethod]
        public void ExH2_TestOneChar()
        {
            int index = ExH2.FindWord("The brown fox", "o");
            Debug.WriteLine("The brown fox, o => should return 6");
            Assert.AreEqual(6, index);
        }

        [TestMethod]
        public void ExH2_TestPositive1()
        {
            int index = ExH2.FindWord("The brown fox", "FOX");
            Debug.WriteLine("The brown fox, FOX => should return 10");
            Assert.AreEqual(10, index);
        }

        [TestMethod]
        public void ExH2_TestPositive2()
        {
            int index = ExH2.FindWord("The brown fox", "bRO");
            Debug.WriteLine("The brown fox, bRO => should return 4");
            Assert.AreEqual(4, index);
        }

        [TestMethod]
        public void ExH2_TestNegative1()
        {
            int index = ExH2.FindWord("T", "bRO");
            Debug.WriteLine("T, FOX => should return -1");
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void ExH2_TestNegative2()
        {
            int index = ExH2.FindWord("The bras basah complex", "bRO");
            Debug.WriteLine("The bras basah complex, bRO => should return -1");
            Assert.AreEqual(-1, index);
        }
    }
}