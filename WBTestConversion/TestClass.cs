// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using BaseConversion;

namespace WBTestConversion
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
        public void TestValidateStmt1()
        {
            var expectedPath = "AJKL";
            var expectedResult = false;

            var input = "abc";
            var inputMin = 1;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestValidateStmt2()
        {
            var expectedPath = "AHIL";
            var expectedResult = false;

            var input = "2147483747";
            var inputMin = 1;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestValidateStmt3()
        {
            var expectedPath = "ABCGL";
            var expectedResult = false;

            var input = "-100";
            var inputMin = 1;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestValidateStmt4()
        {
            var expectedPath = "ABDEFGL";
            var expectedResult = false;

            var input = "1000";
            var inputMin = 1;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
    }
}
