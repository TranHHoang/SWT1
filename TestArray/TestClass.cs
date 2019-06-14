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
        public void CheckValidate()
        {
            // Check string
            bool result1 = Program.checkValidate("abc");
            Assert.AreEqual(result1, false);

            // Check number
            bool result2 = Program.checkValidate("1");
            Assert.AreEqual(result2, true);

            // Check out of int range: 2147483647 + 1
            bool result3 = Program.checkValidate("2147483647 + 1");
            Assert.AreEqual(result3, false);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: User input is a integer number && array size += 1
        [Test]
        public void CheckAdd()
        {
            int[] array = new int[0];
            //Check string
            Program.add(ref array, "abc");
            Assert.AreEqual(array.Length, 0);

            array = new int[0];
            //Check number
            Program.add(ref array, "123123");
            Assert.AreEqual(array.Length, 1);

            array = new int[0];
            // Check out of int range: 2147483647 + 1
            Program.add(ref array, "2147483647 + 1");
            Assert.AreEqual(array.Length, 0);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Check input and return the index number of input in array if have or else return -1
        [Test]
        public void CheckSearch()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int index;
            //Check string
            index = Program.search(array, "abc");
            Assert.AreEqual(index, -1);
                
            // Check out of int range: 2147483647 + 1
            index = Program.search(array, "2147483647 + 1");
            Assert.AreEqual(index, -1);

            //Check number
            index = Program.search(array, "3");
            Assert.AreEqual(index, 3);

            // Check if input doesn't exist in array
            index = Program.search(array, "9");
            Assert.AreEqual(index, -1);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Remove first item = to input encounter in array
        [Test]
        public void CheckRemoveFirst()
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5};
            int originalLength = array.Length;
            //Check string
            Program.removea(ref array, "abc");
            Assert.AreEqual(originalLength, array.Length);

            // Check out of int range: 2147483647 + 1
            Program.removea(ref array, "2147483647 + 1");
            Assert.AreEqual(originalLength, array.Length);

            // Check if input doesn't exist in array
            Program.removea(ref array, "9");
            Assert.AreEqual(originalLength, array.Length);

            //Check number
            Program.removea(ref array, "3");
            Assert.AreEqual(originalLength - 1, array.Length);
        }

        // Black box tesing 
        // Technique: Specification derivered test
        // Statement: Remove all item = to input in array
        [Test]
        public void CheckRemoveAll()
        {
            int[] array = new int[] { 0, 1, 1, 3, 4, 5 };
            int originalLength = array.Length;
            //Check string
            Program.removeall(ref array, "abc");
            Assert.AreEqual(originalLength, array.Length);

            // Check out of int range: 2147483647 + 1
            Program.removeall(ref array, "2147483647 + 1");
            Assert.AreEqual(originalLength, array.Length);

            // Check if input doesn't exist in array
            Program.removeall(ref array, "9");
            Assert.AreEqual(originalLength, array.Length);

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

    }
}
