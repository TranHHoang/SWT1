// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using BaseConversion;

namespace BBTestConversion
{
    [TestFixture]
    public class TestClass
    {

        // Black box testing
        // Technique: Specification derivered test
        // Statement: input inside int range
        [Test]
        public void TestCheckvalidate1()
        {
            bool output = Program.checkValidate("2147483647 + 1", int.MinValue, int.MaxValue);
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: input is a number
        [Test]
        public void TestCheckvalidate2()
        {
            bool output = Program.checkValidate("abc", int.MinValue, int.MaxValue);
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: input inside input range
        [Test]
        public void TestCheckvalidate3()
        {
            bool output = Program.checkValidate("4", 1, 10);
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: input outside input range
        [Test]
        public void TestCheckvalidate4()
        {
            bool output = Program.checkValidate("5", 1, 3);
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a binary number
        [Test]
        public void TestCheckBinary1()
        {
            bool output = Program.checkBinary("abc");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a binary number
        [Test]
        public void TestCheckBinary2()
        {
            bool output = Program.checkBinary("23242341");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a binary number
        [Test]
        public void TestCheckBinary3()
        {
            bool output = Program.checkBinary("101010");
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a octal number
        [Test]
        public void TestCheckOctal1()
        {
            bool output = Program.CheckOctal("abc");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a octal number
        [Test]
        public void TestCheckOctal2()
        {
            bool output = Program.CheckOctal("68678");
            Assert.AreEqual(output, false);
        }
        
        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a octal number
        [Test]
        public void TestCheckOctal3()
        {
            bool output = Program.CheckOctal("1237");
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a hex number
        [Test]
        public void TestCheckHex1()
        {
            bool output = Program.CheckHexadecimal("absdqw");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: is a hex number
        [Test]
        public void TestCheckHex2()
        {
            bool output = Program.CheckHexadecimal("123abc");
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert binary
        [Test]
        public void TestConvertBinary1()
        {
            int output = Program.ConvertBinary("abc");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert binary
        [Test]
        public void TestConvertBinary2()
        {
            int output = Program.ConvertBinary("123123123");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert binary
        [Test]
        public void TestConvertBinary3()
        {
            int output = Program.ConvertBinary("101010");
            Assert.AreEqual(output, 42);
        }
        
        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert octal
        [Test]
        public void TestConvertOctal1()
        {
            int output = Program.ConvertOctal("abc");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert octal
        [Test]
        public void TestConvertOctal2()
        {
            int output = Program.ConvertOctal("99778");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert octal
        [Test]
        public void TestConvertOctal3()
        {
            int output = Program.ConvertOctal("123475");
            Assert.AreEqual(output, 42813);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert hex
        [Test]
        public void TestConvertHex1()
        {
            int output = Program.ConvertHexadecimal("fgh");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Specification derivered test
        // Statement: can convert hex
        [Test]
        public void TestConvertHex2()
        {
            int output = Program.ConvertHexadecimal("1234aff");
            Assert.AreEqual(output, 19090175);
        }

        //====================================================================================================================

        // Black box testing
        // Technique: Equivalence
        // Partition: Non-alphabet
        [Test]
        public void TestCheckvalidate5()
        {
            bool output = Program.checkValidate("abc", int.MinValue, int.MaxValue);
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: > int.MaxValue
        [Test]
        public void TestCheckvalidate6()
        {
            bool output = Program.checkValidate("2147483647 + 1", int.MinValue, int.MaxValue);
            Assert.AreEqual(output, false);
        }
        
        // Black box testing
        // Technique: Equivalence
        // Partition: < int.MinValue
        [Test]
        public void TestCheckvalidate7()
        {
            bool output = Program.checkValidate("-2147483647 - 1", int.MinValue, int.MaxValue);
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: >= int.MinValue && <= int.MaxValue
        [Test]
        public void TestCheckvalidate8()
        {
            bool output = Program.checkValidate("4", int.MinValue, int.MaxValue);
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: Non-alphabet
        [Test]
        public void TestCheckBinary4()
        {
            bool output = Program.checkBinary("abc");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: Contain only 1 and 0
        [Test]
        public void TestCheckBinary5()
        {
            bool output = Program.checkBinary("101010101");
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: Contain other number
        [Test]
        public void TestCheckBinary6()
        {
            bool output = Program.checkBinary("123123");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain 0 to 7 
        [Test]
        public void TestCheckOctal4()
        {
            bool output = Program.CheckOctal("1234567");
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain other number
        [Test]
        public void TestCheckOctal5()
        {
            bool output = Program.CheckOctal("9878");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: Non-alphabet
        [Test]
        public void TestCheckOctal6()
        {
            bool output = Program.CheckOctal("abc");
            Assert.AreEqual(output, false);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain number and a -> f
        [Test]
        public void TestCheckHex3()
        {
            bool output = Program.CheckHexadecimal("abc123");
            Assert.AreEqual(output, true);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain other character
        [Test]
        public void TestCheckHex4()
        {
            bool output = Program.CheckHexadecimal("sgs");
            Assert.AreEqual(output, false);
        }
        
        // Black box testing
        // Technique: Equivalence
        // Partition: contain 0 and 1
        [Test]
        public void TestConvertBinary4()
        {
            int output = Program.ConvertBinary("1010");
            Assert.AreEqual(output, 10);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain other number
        [Test]
        public void TestConvertBinary5()
        {
            int output = Program.ConvertBinary("12345");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: Non-alphabet
        [Test]
        public void TestConvertBinary6()
        {
            int output = Program.ConvertBinary("abc");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain 0 and 7
        [Test]
        public void TestConvertOctal4()
        {
            int output = Program.ConvertOctal("1234");
            Assert.AreEqual(output, 668);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain other number
        [Test]
        public void TestConvertOctal5()
        {
            int output = Program.ConvertOctal("8889");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: Non-alphabet
        [Test]
        public void TestConvertOctal6()
        {
            int output = Program.ConvertOctal("abc");
            Assert.AreEqual(output, 0);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: a -> f and number
        [Test]
        public void TestConvertHex3()
        {
            int output = Program.ConvertHexadecimal("123af");
            Assert.AreEqual(output, 74671);
        }

        // Black box testing
        // Technique: Equivalence
        // Partition: contain other
        [Test]
        public void TestConvertHex4()
        {
            int output = Program.ConvertHexadecimal("sdgt");
            Assert.AreEqual(output, 0);
        }

    }
}
