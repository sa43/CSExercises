using System.Threading;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExD4Test
    {
        [TestMethod]
        public void ExD4_TestSimpleNumber()
        {
            TestHelper.TestOutputContains(typeof(ExD4), "16\r\n", "4.00000");
        }

        [TestMethod]
        public void ExD4_TestBiggerNumber()
        {
            TestHelper.TestOutputContains(typeof(ExD4), "243\r\n", "15.5884");
        }
    }
}