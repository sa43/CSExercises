using System;
using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExF2Test
    {
        [TestMethod]
        public void ExF2_TestForTheOrder()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (ExF2));
            t.WriteLog();
            String lastLine = t.GetOutputFromLast(1);
            string[] parts = lastLine.Split(new char[] {' ', '\t'});

            Debug.WriteLine(lastLine);
            Assert.AreEqual("93", parts[0]);
            Assert.AreEqual("89", parts[1]);
            Assert.AreEqual("3", parts[19]);
        }
    }
}