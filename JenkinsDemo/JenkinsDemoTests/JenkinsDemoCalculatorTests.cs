using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsDemo;

namespace JenkinsDemoTests 
{
    [TestClass]
    public class JenkinsDemoCalculatorTests
    {
        [TestMethod]
        public void AddTest()
        {
            int x = 1;
            int y = 2;
            int expected = 2;
            int actual = Calculator.Add(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivideTest()
        {
            int dividend = 10;
            int divisor = 2;
            int expected = 5;
            int actual = Calculator.Divide(dividend, divisor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void DivideTest_DivisionByZero()
        {
            int dividend = 10;
            int divisor = 0;
            int actual = Calculator.Divide(dividend, divisor);
        }
    }
}
