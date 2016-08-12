using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExG2_Test
    {
        [TestMethod]
        public void ExG2_TestWithMadam()
        {
            TestHelper.TestOutputEqual(typeof(ExG2),"madam","Palindrome");
        }

        [TestMethod]
        public void ExG2_TestWithSanta()
        {
            TestHelper.TestOutputEqual(typeof(ExG2), "A Santa at NASA", "Palindrome");
        }

        [TestMethod]
        public void ExG2_TestWithISS()
        {
            TestHelper.TestOutputEqual(typeof(ExG2), "Institute of Systems Science", "Not Palindrome");
        }

    }
}