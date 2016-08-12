using System;
using System.CodeDom;
using System.Diagnostics;
using System.IO;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExA2Test
    {
        [TestMethod]
        public void ExA2_TestWithAName()
        {
            TestHelper help = new TestHelper();
            help.SetupConsole(new string[] {"John"});
            ExA2.Main(null);
            help.AssertOutputContains("John");
        }
    }
}
