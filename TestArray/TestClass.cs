// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using SWTArray;

namespace TestArray
{
    [TestFixture]
    public class TestClass
    {
        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: User input is a integer number
        [Test]
        public void CheckValidate1()
        {
            // Check string
            bool result1 = Program.checkValidate("abc");
            Assert.AreEqual(result1, false);
        }

        [Test]
        public void CheckValidate2()
        {
            // Check number
            bool result2 = Program.checkValidate("1");
            Assert.AreEqual(result2, true);
        }

        [Test]
        public void CheckValidate3()
        {
            // Check out of int range
            Assert.AreEqual(Program.checkValidate("2147483647 + 1"), false);
            Assert.AreEqual(Program.checkValidate("-2147483647 - 1"), false);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: User input is a integer number && array size += 1
        [Test]
        public void CheckAdd1()
        {
            int[] array = new int[0];
            //Check string
            Program.add(ref array, "abc");
            Assert.AreEqual(array.Length, 0);
        }

        [Test]
        public void CheckAdd2()
        {
            int[] array = new int[0];
            //Check number
            Program.add(ref array, "123123");
            Assert.AreEqual(array.Length, 1);
        }

        [Test]
        public void CheckAdd3()
        {
            int[] array = new int[0];
            // Check out of int range: 2147483647 + 1
            Program.add(ref array, "2147483647 + 1");
            Assert.AreEqual(array.Length, 0);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Check input and return the index number of input in array if have or else return -1
        [Test]
        public void CheckSearch1()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            //Check string
            index = Program.search(array, "abc");
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void CheckSearch2()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            // Check out of int range: 2147483647 + 1
            index = Program.search(array, "2147483647 + 1");
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void CheckSearch3()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            //Check number
            index = Program.search(array, "3");
            Assert.AreEqual(index, 3);
        }

        [Test]
        public void CheckSearch4()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            // Check if input doesn't exist in array
            index = Program.search(array, "9");
            Assert.AreEqual(index, -1);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Remove first item = to input encounter in array
        [Test]
        public void CheckRemoveFirst1()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            //Check string
            Program.removea(ref array, "abc");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveFirst2()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            // Check out of int range: 2147483647 + 1
            Program.removea(ref array, "2147483647 + 1");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveFirst3()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            // Check if input doesn't exist in array
            Program.removea(ref array, "9");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveFirst4()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            //Check number
            Program.removea(ref array, "6");
            Assert.AreEqual(originalLength, array.Length);
            Program.removea(ref array, "3");
            Assert.AreEqual(originalLength - 1, array.Length);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Remove all item = to input in array
        [Test]
        public void CheckRemoveAll1()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            //Check string
            Program.removeall(ref array, "abc");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveAll2()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            // Check out of int range: 2147483647 + 1
            Program.removeall(ref array, "2147483647 + 1");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveAll3()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            // Check if input doesn't exist in array
            Program.removeall(ref array, "9");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveAll4()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            //Check number
            Program.removeall(ref array, "1");
            Assert.AreEqual(originalLength - 2, array.Length);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Array sorted increase
        [Test]
        public void CheckSortUp()
        {
            int[] array = new int[] { 5, 3, 4, 2, 1, 0 };
            int[] expectedArray = new int[] { 0, 1, 2, 3, 4, 5 };
            //Check array
            Program.selectionsortup(array);
            Assert.AreEqual(array, expectedArray);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Array sorted decrease
        [Test]
        public void CheckSortDown()
        {
            int[] array = new int[] { 1, 0, 4, 3, 2, 5 };
            int[] expectedArray = new int[] { 5, 4, 3, 2, 1, 0 };
            //Check array
            Program.selectionsortdown(array);
            Assert.AreEqual(array, expectedArray);
        }


        // ----------------------------------------------------------------------------------------

        // Black box testing
        // Technique: Equivalence test
        [Test]
        public void CheckAdd4()
        {
            int[] array = new int[0];
            // Partition: < int.MinValue - 1   
            Program.add(ref array, "-2147483647 - 1");
            Assert.AreEqual(array.Length, 0);
        }
        
        [Test]
        public void CheckAdd5()
        {
            int[] array = new int[0];
            // Partition: >= int.MinValue && <= int.MaxValue   
            Program.add(ref array, "4");
            Assert.AreEqual(array.Length, 1);
        }
        
        [Test]
        public void CheckAdd6()
        {
            int[] array = new int[0];
            // Partition: > int.MaxValue + 1  
            Program.add(ref array, "2147483647 + 1");
            Assert.AreEqual(array.Length, 0);
        }
        
        [Test]
        public void CheckAdd7()
        {
            int[] array = new int[0];
            // Partition: Non-digit   
            Program.add(ref array, "abc");
            Assert.AreEqual(array.Length, 0);
        }


        // Black box testing
        // Technique: Equivalence test
        [Test]
        public void CheckSearch5()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            // Partition: < int.MinValue - 1  
            index = Program.search(array, "-2147483647 - 1");
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void CheckSearch6()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            // Partition: >= int.MinValue && <= int.MaxValue  
            index = Program.search(array, "4");
            Assert.AreEqual(index, 4);
            index = Program.search(array, "9");
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void CheckSearch7()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            // Partition: > int.MaxValue + 1  
            index = Program.search(array, "2147483647 + 1");
            Assert.AreEqual(index, -1);
        }

        [Test]
        public void CheckSearch8()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            // Partition: Non-digit
            index = Program.search(array, "abc");
            Assert.AreEqual(index, -1);
        }


        // Black box testing
        // Technique: Equivalence test
        [Test]
        public void CheckRemoveFirst5()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            // Partition: Non-digit
            Program.removea(ref array, "abc");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveFirst6()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            // Partition: > int.MaxValue
            Program.removea(ref array, "2147483647 + 1");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveFirst7()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            // Partition: < int.MinValue
            Program.removea(ref array, "-2147483647 - 1");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveFirst8()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5 };
            int originalLength = array.Length;
            // Prtition: > int.MinValue && < int.MaxValue
            Program.removea(ref array, "6");
            Assert.AreEqual(originalLength, array.Length);
            Program.removea(ref array, "3");
            Assert.AreEqual(originalLength - 1, array.Length);
        }

        // Black box testing
        // Technique: Equivalence
        [Test]
        public void CheckRemoveAll5()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            // Partition: < int.MinValue
            Program.removeall(ref array, "-2147483647 - 1");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveAll6()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            // Partition: > int.MinValue && < int.MaxValue
            Program.removeall(ref array, "6");
            Assert.AreEqual(originalLength, array.Length);
            Program.removeall(ref array, "1");
            Assert.AreEqual(originalLength - 2, array.Length);
        }

        [Test]
        public void CheckRemoveAll7()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            // Partition: > int.MaxValue
            Program.removeall(ref array, "2147483647 + 1");
            Assert.AreEqual(originalLength, array.Length);
        }

        [Test]
        public void CheckRemoveAll8()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            // Partition: Non-digit
            Program.removeall(ref array, "abc");
            Assert.AreEqual(originalLength, array.Length);
        }


        // ----------------------------------------------------------------------------------------

        // Black box testing
        // Techinique: Boundary test
        [Test]
        public void CheckAdd8()
        {
            int[] array = new int[0];
            // Border: < int.MinValue - 1   
            Program.add(ref array, "-2147483647 - 1");
            Assert.AreEqual(array.Length, 0);
        }

        [Test]
        public void CheckAdd9()
        {
            int[] array = new int[0];
            // Border: < int.MinValue + 1   
            Program.add(ref array, "-2147483646");
            Assert.AreEqual(array.Length, 1);
        }

        [Test]
        public void CheckAdd10()
        {
            int[] array = new int[0];
            // Border: = int.MinValue  
            Program.add(ref array, "-2147483647");
            Assert.AreEqual(array.Length, 1);
        }

        [Test]
        public void CheckAdd11()
        {
            int[] array = new int[0];
            // Border: < int.MaxValue - 1   
            Program.add(ref array, "2147483646");
            Assert.AreEqual(array.Length, 1);
        }

        [Test]
        public void CheckAdd12()
        {
            int[] array = new int[0];
            // Border: < int.MaxValue + 1   
            Program.add(ref array, "2147483647 + 1");
            Assert.AreEqual(array.Length, 0);
        }

        [Test]
        public void CheckAdd13()
        {
            int[] array = new int[0];
            // Border: = int.MaxValue  
            Program.add(ref array, "2147483647");
            Assert.AreEqual(array.Length, 1);
        }

        [Test]
        public void CheckAdd14()
        {
            int[] array = new int[0];
            // Border: = Non-digit
  
            Program.add(ref array, "abc");
            Assert.AreEqual(array.Length, 0);
        }

        // Black box testing
        // Technique: Boundary test

    }
}
