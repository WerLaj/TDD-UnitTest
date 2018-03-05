using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void EmptyString()
        {
            string zerothString = "";
            int expectedSum = 0;
            Program prog = new Program();
            int actualSum = prog.Add(zerothString);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void OneNumberString()
        {
            string oneString = "5";
            int expectedSum = 5;
            Program prog = new Program();
            int actualSum = prog.Add(oneString);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void TwoNumberString()
        {
            string oneString = "5,4";
            int expectedSum = 9;
            Program prog = new Program();
            int actualSum = prog.Add(oneString);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void MoreNumbersString()
        {
            string oneString = "5\n4,3,2,1";
            int expectedSum = 15;
            Program prog = new Program();
            int actualSum = prog.Add(oneString);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
