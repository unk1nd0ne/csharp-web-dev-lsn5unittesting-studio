using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void TestEmptyBrackets()
        {
            string testString = "[]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestBaracketsWithString()
        {
            string testString = "[LaunchCode Rocks!]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestUnbalancedBrackets()
        {
            string testString = "[This should return false";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestReversedBrackets()
        {
            string testString = "][";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestNestedBrackets()
        {
            string testString = "[[]]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            string testString = "";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestSingleOpeningBacket()
        {
            string testString = "[";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestSingleClosingBracket()
        {
            string testString = "]";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        public void TestBaracketsInsideString()
        {
            string testString = "LaunchCode [Rocks!]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestBalancedBeginingThenUnbalanced()
        {
            string testString = "[]][";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestBaracketsBeforeString()
        {
            string testString = "[]LaunchCode";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestUnbalancedBracketsInsideString()
        {
            string testString = "Launch]Code[";
            Assert.AreEqual(false, BalancedBrackets.HasBalancedBrackets(testString));
        }

        [TestMethod]
        public void TestBaracketsWithSpecialChars()
        {
            string testString = "!@#$%^&*[()-=_+]";
            Assert.AreEqual(true, BalancedBrackets.HasBalancedBrackets(testString));
        }
    }
     
}
