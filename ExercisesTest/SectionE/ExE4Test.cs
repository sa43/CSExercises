using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExE4Test
    {
        [TestMethod]
        public void ExE4_Test496()
        {
            TestHelper.TestOutputContains(typeof(ExE4), "496\r\n", "Perfect Number");
        }

        [TestMethod]
        public void ExE4_Test240()
        {
            TestHelper.TestOutputContains(typeof(ExE4), "240\r\n", "Not Perfect Number");
        }
    }
}