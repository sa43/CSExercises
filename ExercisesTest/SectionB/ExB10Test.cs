using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExB10_Test
    {
        [TestMethod]
        public void ExB10_TestWithZero()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "0", "0", "0" });
            TestHelper.RunMain(typeof(ExB10));
            t.AssertOutput(0.ToString());
        }

        [TestMethod]
        public void ExB10_TestWithPositiveNumber()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "3","4","5"});
            TestHelper.RunMain(typeof (ExB10));
            t.AssertOutput(6.ToString());
        }

    }
}