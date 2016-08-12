using System;
using System.Threading;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExD3Test
    {
        [TestMethod]
        public void ExD3_TestRepeatedly()
        {
            bool cond1 = false;
            bool cond2 = false;
            bool cond3 = false;

            do
            {
                TestHelper t = new TestHelper();
                t.SetupConsole(new string[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"});
                TestHelper.RunMain(typeof (ExD3));
                int count = t.GetOutputCount() - 1;
                if (count <= 2)
                {
                    t.AssertOutputContains("wizard");
                    cond1 = true;
                }
                else if (count <= 5)
                {
                    t.AssertOutputContains("good");
                    cond2 = true;
                }
                else
                {
                    t.AssertOutputContains("lousy");
                    cond3 = true;
                }

                Thread.Sleep(100);
            } while (!(cond1 && cond2 && cond3));
        }

    }
}