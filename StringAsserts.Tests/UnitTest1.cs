using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Hello from The Test World", "from");
        }

        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches("Hello from The Test World", new Regex(@"[a-zA-z]"));
            StringAssert.DoesNotMatch("Hello from The Test World", new Regex(@"[0-9]"));
        }

        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Hello from The Test World", "Hello");
        }

        [TestMethod]
        public void EndsWithTest()
        {
            StringAssert.EndsWith("Hello from The Test World", "World");
        }
    }
}