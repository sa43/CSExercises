using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    class TestHelper
    {
        ConsoleLog l;
        FakeStringWriter tw;
        TextReader tr;

        public TestHelper() 
        {
            l = new ConsoleLog();
            tw = new FakeStringWriter(l);
            Console.SetOut(tw);
        }

        public void SetupConsole(string input)
        {
            TextReader tr = new FakeStringReader(input, l, tw );
            Console.SetIn(tr);
        }

        public void SetupConsole(string[] inputs)
        {
            string input = "";
            foreach (var str in inputs)
            {
                input += str + "\r\n";
            }
            SetupConsole(input);
        }

        public void AssertOutput(string expectedOutput)
        {
            Debug.WriteLine(l.Log);
            tw.RemoveEmptyEntries();
            Assert.IsTrue(tw.Entries.Count>0,"There is no output detected");
            Assert.AreEqual(expectedOutput.Trim().ToLower(), tw.Entries[tw.Entries.Count - 1].Trim().ToLower(),"Program output is different from the expected output.");
        }

        public void AssertOutputContains(string expectedOutput)
        {
            Debug.WriteLine(l.Log);
            tw.RemoveEmptyEntries();
            Assert.IsTrue(tw.Entries.Count > 0, "There is no output detected");
            Assert.IsTrue(tw.Entries[tw.Entries.Count - 1].Trim().ToLower().Contains(expectedOutput.Trim().ToLower()), "Program output do not contain the expected output ("+expectedOutput+").");
        }

        public void AssertOutputContains(int positionFromBack, string expectedOutput, bool log)
        {
            tw.RemoveEmptyEntries();
            if (log)
            {
                Debug.WriteLine(l.Log);
                Assert.IsTrue(tw.Entries.Count > 0, "There is no output detected");
            }
            Assert.IsTrue(tw.Entries[tw.Entries.Count - positionFromBack].Trim().ToLower().Contains(expectedOutput.Trim().ToLower()), "Program output do not contain the expected output (" + expectedOutput + ").");
        }

        public int CountOutputContaining(string output)
        {
            tw.RemoveEmptyEntries();
            int count = 0;
            for (int i = 0; i < tw.Entries.Count; i++)
            {
                if (tw.Entries[i].Trim().ToLower().Contains(output))
                    count++;
            }
            return count;
        }

        public void AssertOutputNotContaining(string expectedOutput)
        {
            Debug.WriteLine(l.Log);
            tw.RemoveEmptyEntries();
            Assert.IsTrue(tw.Entries.Count > 0, "There is no output detected");
            Assert.IsFalse(tw.Entries[tw.Entries.Count - 1].Trim().ToLower().Contains(expectedOutput.Trim().ToLower()), "Program output should not contain the the string " + expectedOutput + ".");
        }


        public static void TestOutputEqual(Type t,  string input, string output)
        {
            TestHelper help = new TestHelper();

            help.SetupConsole(input);
            RunMain(t);
            help.AssertOutput(output);
        }

        public static void RunMain(Type t)
        {
            var methodInfo = t.GetMethod("Main");
            if (methodInfo != null)
            {
                methodInfo.Invoke(null, new object[] { null });
            }
        }

        public static void TestOutputContains(Type t, string input, string output)
        {
            TestHelper help = new TestHelper();

            help.SetupConsole(input);
            RunMain(t);
            help.AssertOutputContains(output);
        }

        public static bool ExecuteMain(Type t, int timeout)
        {
            var methodInfo = t.GetMethod("Main");
            if (methodInfo != null)
            {
                return TryExecute(new Action(()=>
                {
                    methodInfo.Invoke(null, new object[] { null });                      
                }), timeout);
            }
            return true;
        }

        public static bool TryExecute(Action action, int timeout)
        {
            var thread = new Thread(() => action());
            thread.Start();
            var completed = thread.Join(timeout);
            if (!completed) thread.Abort();
            //result = t;
            return completed;
        }

        public void WriteLog()
        {
            Debug.WriteLine(l.Log);
        }

        public string GetOutputFromLast(int i)
        {
            return tw.Entries[tw.Entries.Count - i];
        }

        public int GetOutputCount()
        {
            return tw.Entries.Count;
        }
    }
}
