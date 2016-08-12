using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExC1Test
    {
        [TestMethod]
        public void ExC1_TestWithMale()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "John Smith", "M"});
            TestHelper.RunMain(typeof(ExC1));
            t.AssertOutput("Good Morning Mr. John Smith".ToString());
        }

        [TestMethod]
        public void ExC1_TestWithFemale()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Jane Austen","F"});
            TestHelper.RunMain(typeof (ExC1));
            t.AssertOutput("Good Morning Ms. Jane Austen".ToString());
        }

        [TestMethod]
        public void ExC1_TestWithUnknown()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Jane Austen", "X" });
            TestHelper.RunMain(typeof(ExC1));
            t.AssertOutputNotContaining("Jane Austen");
        }
    }
}