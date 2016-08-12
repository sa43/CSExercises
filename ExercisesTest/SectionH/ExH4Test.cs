using System.Diagnostics;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExH4Test
    {
        [TestMethod]
        public void ExH4_TestNoSubstitution()
        {
            Debug.WriteLine("Bad dog, e, o => Bad dog");
            Assert.AreEqual("Bad dog", ExH4.Substitute("Bad dog",'e','o'));
        }

        [TestMethod]
        public void ExH4_TestMultipleSubstitution()
        {
            Debug.WriteLine("Bad dog, d, f => Baf fog");
            Assert.AreEqual("Baf fog", ExH4.Substitute("Bad dog", 'd', 'f'));
        }
    
    }
}