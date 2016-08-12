using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExD1Test
    {
        [TestMethod]
        public void ExD1_TestWith88()
        {
            TestHelper t = new TestHelper();
            Random r = new Random();
            t.SetupConsole(new string[] { r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), "88" });
            TestHelper.RunMain(typeof(ExD1));
            t.AssertOutputContains("Lucky");
        }

        [TestMethod]
        public void ExD1_TestNo88()
        {
            TestHelper t = new TestHelper();
            Random r = new Random();
            t.SetupConsole(new string[] { r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), r.Next(1, 100).ToString(), "87" });
            bool completed = TestHelper.ExecuteMain(typeof(ExD1),100);
            Assert.IsFalse(completed,"The program is not supposed to complete, but it is.");
            t.WriteLog();
        }

    }
}