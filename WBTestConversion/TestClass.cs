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

        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestValidateDecision1()
        {
            var expectedPath = "AJKL";
            var expectedResult = false;

            var input = "zzzzz";
            var inputMin = 1;
            var inputMax = 100;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestValidateDecision2()
        {
            var expectedPath = "AHIL";
            var expectedResult = false;

            var input = "6442450941";
            var inputMin = -10;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestValidateDecision3()
        {
            var expectedPath = "ABCGL";
            var expectedResult = false;

            var input = "-1200";
            var inputMin = -8;
            var inputMax = -10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestValidateDecision4()
        {
            var expectedPath = "ABDEFGL";
            var expectedResult = false;

            var input = "1000";
            var inputMin = 2;
            var inputMax = 5;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidatePath1()
        {
            var expectedPath = "AJKL";
            var expectedResult = false;

            var input = "bcax";
            var inputMin = 1;
            var inputMax = 100;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidatePath2()
        {
            var expectedPath = "AHIL";
            var expectedResult = false;

            var input = "999999999999";
            var inputMin = -1;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidatePath3()
        {
            var expectedPath = "ABCGL";
            var expectedResult = false;

            var input = "-9990";
            var inputMin = -10;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidatePath4()
        {
            var expectedPath = "ABDEFGL";
            var expectedResult = false;

            var input = "10000";
            var inputMin = 2;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestValidatePath5()
        {
            var expectedPath = "ABDFGL";
            var expectedResult = true;

            var input = "7";
            var inputMin = -2;
            var inputMax = 10;

            Assert.AreEqual(expectedResult, Program.checkValidate(input, inputMin, inputMax));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestCheckBinaryStmt1()
        {
            var expectedPath = "ABCFG";
            var expectedResult = false;

            var input = "oooollllll";

            Assert.AreEqual(expectedResult, Program.checkBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }

    }
}
