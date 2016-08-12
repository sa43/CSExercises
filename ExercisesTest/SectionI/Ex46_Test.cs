using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExI2Test
    {
        [TestMethod]
        public void ExI2_TestRandomMaybeAlotOfFalseResult()
        {
            //trying 10 times hoping for any number to go beyond 10
            for (int k = 0; k < 10; k++)
            {
                TestHelper t = new TestHelper();
                t.SetupConsole(new string[] {});
                TestHelper.RunMain(typeof (ExI2));
                t.WriteLog();
                Assert.IsTrue(t.GetOutputCount() != 0, "No output detected");
                int residue = 0;
                for (int i = 20; i >= 10; i--)
                {
                    string stars = "";
                    for (int j = 0; j < i; j++) stars += "*";
                    int c1 = t.CountOutputContaining(i.ToString());
                    int c2 = t.CountOutputContaining(stars);

                    Assert.AreEqual(c1 + residue, c2,
                        "The number of rows with {0} count and {0} stars doesn't seems to tally", i);
                    residue += c1; //rows with 10 stars also contains 9 stars so we need to count it too
                }
            }
        }

    }
}