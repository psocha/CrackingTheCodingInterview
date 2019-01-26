using System;
using CTCI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch1_Tests
{
    [TestClass]
    public class StringUniquenessCheckerTest
    {
        [TestMethod]
        public void IsUniqueTest()
        {
            Assert.IsTrue(StringUniquenessChecker.IsStringAllUniqueChars("qwertyuiopasdfghjklzxcvbnm"));
            Assert.IsFalse(StringUniquenessChecker.IsStringAllUniqueChars("asdfa"));
            Assert.IsTrue(StringUniquenessChecker.IsStringAllUniqueChars(""));
            Assert.IsFalse(StringUniquenessChecker.IsStringAllUniqueChars("ZZZZZZZZZZZZZZZZZZZZZ"));
        }
    }
}
