using System;
using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExH3Test
    {
        [TestMethod]
        public void ExH3_TestOneToOneHundred()
        {
            for (int i = 1; i <= 100; i++)
            {
                string expected = i.ToString("X");
                string output = ExH3.Hex(i);
                Debug.WriteLine("Hex of {0} should be {1}", i, expected);
                Assert.AreEqual(expected, output);
            }
        }
    }
}