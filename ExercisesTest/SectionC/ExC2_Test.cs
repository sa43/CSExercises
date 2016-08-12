using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExC2_Test
    {
        [TestMethod]
        public void ExC2_TestWithUncle()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Arnold", "M", "40"});
            TestHelper.RunMain(typeof(ExC2));
            t.AssertOutput("Good Morning Uncle Arnold".ToString());
        }

        [TestMethod]
        public void ExC2_TestWithAunty()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Madonna", "F", "51" });
            TestHelper.RunMain(typeof (ExC2));
            t.AssertOutput("Good Morning Aunty Madonna".ToString());
        }

        [TestMethod]
        public void ExC2_TestWitMr()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Will Smith", "M" });
            TestHelper.RunMain(typeof(ExC2));
            t.AssertOutput("Good Morning Mr. Will Smith".ToString());
        }

        [TestMethod]
        public void ExC2_TestWithMs()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Ariana Grande", "F", "18" });
            TestHelper.RunMain(typeof(ExC2));
            t.AssertOutput("Good Morning Ms. Ariana Grande".ToString());
        }

        [TestMethod]
        public void ExC2_TestWithUnknown()
        {
            TestHelper t = new TestHelper();
            t.SetupConsole(new string[] { "Jane Austen", "X", "20" });
            TestHelper.RunMain(typeof(ExC2));
            t.AssertOutputNotContaining("Jane Austen");
        }
    }
}