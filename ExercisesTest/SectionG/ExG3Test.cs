using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExG3Test
    {

        [TestMethod]
        public void ExG3_TestWithOneWord()
        {
            TestHelper.TestOutputContains(typeof(ExG3), "   ball ", "   Ball");
        }

        [TestMethod]
        public void ExG3_TestWithISS()
        {
            TestHelper.TestOutputContains(typeof(ExG3), "institute Of systems science", "Institute of Systems Science");
        }

    }
}