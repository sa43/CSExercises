using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExE3Test
    {
        [TestMethod]
        public void ExE3_Test241()
        {
            TestHelper.TestOutputContains(typeof(ExE3), "241\r\n", "Prime");
        }

        [TestMethod]
        public void ExE3_Test240()
        {
            TestHelper.TestOutputContains(typeof(ExE3), "240\r\n", "Not Prime");
        }
    }
}