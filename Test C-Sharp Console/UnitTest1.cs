using System;
using System.Collections.Generic;
using C_Sharp_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_C_Sharp_Console
{
    [TestClass]
    public class RecursiveFunctionsTests
    {
        [TestMethod]
        public void fibonacci()
        {
            RecursiveFunctions recursive = new RecursiveFunctions();
            Dictionary<int,int> TestDictionary = new Dictionary<int, int>
            {
                { 21,8},
                { 233,13},
                { 1597,17},
                { 4181,19},
                { 6765,20},
                { 28657,23}
            };
            foreach (KeyValuePair<int, int> value in TestDictionary)
            {
                Assert.AreEqual(value.Key, recursive.fibonacci(value.Value));
            }
        }


    }

    [TestClass]
    public class NrepeatedElementTests
    {
        NrepeatedElement repeatedObject = new NrepeatedElement();
        Dictionary<int,int[]> Test = new Dictionary<int, int[]>()
        {
            { 2, new int[]{ 2,3,2,6 } },
            { 3, new int[]{ 3,4,5,6,2,3,2 } }
        };

        [TestMethod]
        public void RepeatedDictionary()
        {
            foreach(KeyValuePair<int,int[]> pair in Test)
            {
                Assert.AreEqual(pair.Key, repeatedObject.RepeatedDictionary(pair.Value));
            }
        }

        [TestMethod]
        public void RepeatedNaive()
        {
            foreach (KeyValuePair<int, int[]> pair in Test)
            {
                Assert.AreEqual(pair.Key, repeatedObject.RepeatedNaive(pair.Value));
            }
        }


    }


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
