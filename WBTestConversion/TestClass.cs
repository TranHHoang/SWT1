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
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestCheckBinaryStmt2()
        {
            var expectedPath = "ABDEBDEFG";
            var expectedResult = true;

            var input = "10";

            Assert.AreEqual(expectedResult, Program.checkBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestCheckBinaryDecision1()
        {
            var expectedPath = "ABCFG";
            var expectedResult = false;

            var input = "kokokokokok";

            Assert.AreEqual(expectedResult, Program.checkBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestCheckBinaryDecision2()
        {
            var expectedPath = "ABDEFG";
            var expectedResult = true;

            var input = "0";

            Assert.AreEqual(expectedResult, Program.checkBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestCheckBinaryPath1()
        {
            var expectedPath = "ABCFG";
            var expectedResult = false;

            var input = "xxyxxyx";

            Assert.AreEqual(expectedResult, Program.checkBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestCheckBinaryPath2()
        {
            var expectedPath = "ABDEBDEBDEFG";
            var expectedResult = true;

            var input = "101";

            Assert.AreEqual(expectedResult, Program.checkBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestCheckOctStmt1()
        {
            var expectedPath = "ABCEF";
            var expectedResult = false;

            var input = "8889";

            Assert.AreEqual(expectedResult, Program.CheckOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestCheckOctStmt2()
        {
            var expectedPath = "ABDBDEF";
            var expectedResult = true;

            var input = "16";

            Assert.AreEqual(expectedResult, Program.CheckOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestCheckOctDecision1()
        {
            var expectedPath = "ABCEF";
            var expectedResult = false;

            var input = "ATM";

            Assert.AreEqual(expectedResult, Program.CheckOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestCheckOctDecision2()
        {
            var expectedPath = "ABDBDBDEF";
            var expectedResult = true;

            var input = "247";

            Assert.AreEqual(expectedResult, Program.CheckOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestCheckOctPath1()
        {
            var expectedPath = "ABCEF";
            var expectedResult = false;

            var input = "good";

            Assert.AreEqual(expectedResult, Program.CheckOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestCheckOctPath2()
        {
            var expectedPath = "ABDBDBDEF";
            var expectedResult = true;

            var input = "374";

            Assert.AreEqual(expectedResult, Program.CheckOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestCheckHexStmt1()
        {
            var expectedPath = "ABCEF";
            var expectedResult = false;

            var input = "xzy";

            Assert.AreEqual(expectedResult, Program.CheckHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestCheckHexStmt2()
        {
            var expectedPath = "ABDBDEF";
            var expectedResult = true;

            var input = "C9";

            Assert.AreEqual(expectedResult, Program.CheckHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestCheckHexDecision1()
        {
            var expectedPath = "ABDBCEF";
            var expectedResult = false;

            var input = "atm";

            Assert.AreEqual(expectedResult, Program.CheckHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestCheckHexDecision2()
        {
            var expectedPath = "ABDBDBDEF";
            var expectedResult = true;

            var input = "247";

            Assert.AreEqual(expectedResult, Program.CheckHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestCheckHexPath1()
        {
            var expectedPath = "ABCEF";
            var expectedResult = false;

            var input = "GoodMorning";

            Assert.AreEqual(expectedResult, Program.CheckHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestCheckHexPath2()
        {
            var expectedPath = "ABDBDBDEF";
            var expectedResult = true;

            var input = "7FF";

            Assert.AreEqual(expectedResult, Program.CheckHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestConvertBinStmt1()
        {
            var expectedPath = "A'BFG";
            var expectedResult = 0;

            var input = "123";

            Assert.AreEqual(expectedResult, Program.ConvertBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestConvertBinStmt2()
        {
            var expectedPath = "A'BCDDDDEFG";
            var expectedResult = 15;

            var input = "1111";

            Assert.AreEqual(expectedResult, Program.ConvertBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestConvertBinDecision1()
        {
            var expectedPath = "A'BFG";
            var expectedResult = 0;

            var input = "ATM";

            Assert.AreEqual(expectedResult, Program.ConvertBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestConvertBinDecision2()
        {
            var expectedPath = "A'BCDDDDDEFG";
            var expectedResult = 21;

            var input = "10101";

            Assert.AreEqual(expectedResult, Program.ConvertBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestConvertBinPath1()
        {
            var expectedPath = "A'BFG";
            var expectedResult = 0;

            var input = "XYZZZZ";

            Assert.AreEqual(expectedResult, Program.ConvertBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestConvertBinPath2()
        {
            var expectedPath = "A'BCDDDDEFG";
            var expectedResult = 14;

            var input = "1110";

            Assert.AreEqual(expectedResult, Program.ConvertBinary(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestConvertOctStmt1()
        {
            var expectedPath = "A'BGH";
            var expectedResult = 0;

            var input = "hellll";

            Assert.AreEqual(expectedResult, Program.ConvertOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestConvertOctStmt2()
        {
            var expectedPath = "A'BCDEEEFGH";
            var expectedResult = 83;

            var input = "123";

            Assert.AreEqual(expectedResult, Program.ConvertOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestConvertOctDecision1()
        {
            var expectedPath = "A'BGH";
            var expectedResult = 0;

            var input = "779999";

            Assert.AreEqual(expectedResult, Program.ConvertOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestConvertOctDecision2()
        {
            var expectedPath = "A'BCDEEEFGH";
            var expectedResult = 103;

            var input = "147";

            Assert.AreEqual(expectedResult, Program.ConvertOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestConvertOctPath1()
        {
            var expectedPath = "A'BGH";
            var expectedResult = 0;

            var input = "3216549";

            Assert.AreEqual(expectedResult, Program.ConvertOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestConvertOctPath2()
        {
            var expectedPath = "A'BCDEEFGH";
            var expectedResult = 63;

            var input = "77";

            Assert.AreEqual(expectedResult, Program.ConvertOctal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestConvertHexStmt1()
        {
            var expectedPath = "A'BCDEFHIFGIFGIJKL";
            var expectedResult = 314;

            var input = "13a";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: statement coverage
        [Test]
        public void TestConvertHexStmt2()
        {
            var expectedPath = "A'BKL";
            var expectedResult = 0;

            var input = "xzxzxzx";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestConvertHexDecision1()
        {
            var expectedPath = "A'BCDEFGIJKL";
            var expectedResult = 8;

            var input = "8";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestConvertHexDecision2()
        {
            var expectedPath = "A'BCDEFHIJKL";
            var expectedResult = 10;

            var input = "A";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: decision coverage
        [Test]
        public void TestConvertHexDecision3()
        {
            var expectedPath = "A'BKL";
            var expectedResult = 0;

            var input = "GiatMinhTrongDem";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestConvertHexPath1()
        {
            var expectedPath = "A'BCDEFGIFGIFGIJKL";
            var expectedResult = 579;

            var input = "243";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestConvertHexPath2()
        {
            var expectedPath = "A'BCDEFHIFHIJKL";
            var expectedResult = 255;

            var input = "ff";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
        // White box tesing 
        // Technique: path coverage
        [Test]
        public void TestConvertHexPath3()
        {
            var expectedPath = "A'BKL";
            var expectedResult = 0;

            var input = "zzzzzzzzzzzzzzz";

            Assert.AreEqual(expectedResult, Program.ConvertHexadecimal(input));
            Assert.AreEqual(expectedPath, Program.PathOutput);
        }
    }
}
