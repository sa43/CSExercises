using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExG4Test
    {
        [TestMethod]
        public void ExG4_TestOrder()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole("");
            TestHelper.RunMain(typeof (ExG4));
            t.AssertOutputContains(1, "Victor", true);
            t.AssertOutputContains(2, "Venkat", false);
            t.AssertOutputContains(3, "Mary", false);
            t.AssertOutputContains(4, "John", false);
        }
    }
}