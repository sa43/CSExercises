using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExE6_Test
    {
        [TestMethod]
        public void ExE6_TestForTheOnlyTestCase()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof(ExE6));
            t.AssertOutputContains(1, "496", true);
            t.AssertOutputContains(2, "28", false);
            t.AssertOutputContains(3, "6", false);
        }
    }
}