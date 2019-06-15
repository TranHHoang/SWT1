// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SWTArray;

namespace WBTestArray
{
    [TestFixture]
    public class TestClass
    {
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestValidate1()
        {
            var expectedPath = "ABI";
            var input = "abc";
            var expectedResult = false;
            Program.PathOutput = "";

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestValidate2()
        {
            var expectedPath = "ACDHI";
            var input = "-8589934592";
            var expectedResult = false;
            Program.PathOutput = "";

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestAdd()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "abc";

            var expectedSize = 4;
            var expectedEnd = 4;
            var expectedPath = "AD";

            Program.add(ref inputArr, input);

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestRemove()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "abc";

            var expectedSize = 3;
            var expectedEnd = 4;
            var expectedPath = "AD";

            Program.removea(ref inputArr, "2");

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
    }
}
