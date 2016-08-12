using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExA5Test
    {
        [TestMethod]
        public void ExA5_Case1()
        {
            TestHelper help = new TestHelper();
            help.SetupConsole(new string[] { "100.1" });
            ExA5.Main(null);
            help.AssertOutputContains("100.10");
        }

        [TestMethod]
        public void ExA5_Case2()
        {
            TestHelper help = new TestHelper();
            help.SetupConsole(new string[] { "0" });
            ExA5.Main(null);
            help.AssertOutputContains("0.00");
        }

        [TestMethod]
        public void ExA5_Case3()
        {
            TestHelper help = new TestHelper();
            help.SetupConsole(new string[] { "3.232" });
            ExA5.Main(null);
            help.AssertOutputContains("3.23");
        }

        [TestMethod]
        public void ExA5_Case4()
        {
            TestHelper help = new TestHelper();
            help.SetupConsole(new string[] { "4.555" });
            ExA5.Main(null);
            help.AssertOutputContains("4.56");
        }
    }
}
