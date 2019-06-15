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
        [SetUp]
        public void SetUp()
        {
            Program.PathOutput = "";
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestValidate1()
        {
            var expectedPath = "ACD";
            var input = "abc";
            var expectedResult = false;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestValidate2()
        {
            var expectedPath = "ABD";
            var input = "-2147483649";
            var expectedResult = false;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestAdd1()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "abc";

            var expectedSize = 4;
            var expectedEnd = 4;
            var expectedPath = "A'BD";

            Program.add(ref inputArr, input);

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestAdd2()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "10";

            var expectedSize = 5;
            var expectedEnd = 10;
            var expectedPath = "A'BCD";

            Program.add(ref inputArr, input);

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestSearch()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "abc";

            var expectedOutput = -1;
            var expectedPath = "A'HI";

            Assert.AreEqual(expectedOutput, Program.search(inputArr, input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        [Test]
        public void TestSearch2()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "5";

            var expectedOutput = -1;
            var expectedPath = "A’BCDEI";

            Assert.AreEqual(expectedOutput, Program.search(inputArr, input));
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

        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestValidate3()
        {
            // TODO: Fix test case
            var expectedPath = "ACD";
            var input = "abc";
            var expectedResult = false;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestValidate4()
        {
            // TODO: Fix test case
            var expectedPath = "ABD";
            var input = "-2147483649";

            var expectedResult = false;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestValidate5()
        {
            // TODO: Fix test case
            var expectedPath = "AD";
            var input = "10";
            var expectedResult = true;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidate6()
        {
            // TODO: Fix test case
            var expectedPath = "ACD";
            var input = "abc";
            var expectedResult = false;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidate7()
        {
            // TODO: Fix test case
            var expectedPath = "ABD";
            var input = "-999999999999";
            var expectedResult = false;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidate8()
        {
            // TODO: Fix test case
            var expectedPath = "AD";
            var input = "100";
            var expectedResult = true;

            Assert.AreEqual(expectedResult, Program.checkValidate(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestAdd3()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "abc";

            var expectedSize = 4;
            var expectedEnd = 4;
            var expectedPath = "A'BD";

            Program.add(ref inputArr, input);

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestAdd4()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "10";

            var expectedSize = 5;
            var expectedEnd = 10;
            var expectedPath = "A'BCD";

            Program.add(ref inputArr, input);

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestAdd5()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "abc";

            var expectedSize = 4;
            var expectedEnd = 4;
            var expectedPath = "A'BD";

            Program.add(ref inputArr, input);

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestAdd6()
        {
            var inputArr = new[] { 1, 2, 3, 4 };
            var input = "10";

            var expectedSize = 5;
            var expectedEnd = 10;
            var expectedPath = "A'BCD";

            Program.add(ref inputArr, input);

            Assert.AreEqual(expectedSize, inputArr.Length);
            Assert.AreEqual(expectedEnd, inputArr[inputArr.Length - 1]);
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
    }
}
