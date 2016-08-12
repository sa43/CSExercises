using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExE2Test
    {
        [TestMethod]
        public void ExE2_TestTheOnlyCase()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (ExE2));
            t.AssertOutputContains(1, "3.162", true);
            t.AssertOutputContains(2, "0.111", false);
            t.AssertOutputContains(3, "64.0", false);
        }
    }
}