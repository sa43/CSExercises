using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExI1Test
    {
        [TestMethod]
        public void ExI1_Test195()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("1.95");
            TestHelper.RunMain(typeof (ExI1));
            t.AssertOutputContains(1, "5c", true);
            t.AssertOutputContains(2, "20c", false);
            t.AssertOutputContains(3, "20c", false);
            t.AssertOutputContains(4, "50c", false);
            t.AssertOutputContains(5, "100c", false);
        }

        [TestMethod]
        public void Ex45_Test105()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("1.05");
            TestHelper.RunMain(typeof(ExI1));
            t.AssertOutputContains(1, "5c", true);
            t.AssertOutputContains(2, "100c", false);
        }
    
    }
}