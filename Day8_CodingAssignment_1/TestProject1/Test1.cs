using System;
using Day8_CodingAssignment_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(5, calculator.Add(2, 3));
            Assert.AreEqual(0, calculator.Add(-2, 2));
            Assert.AreEqual(-5, calculator.Add(-2, -3));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(1, calculator.Subtract(3, 2));
            Assert.AreEqual(-4, calculator.Subtract(-2, 2));
            Assert.AreEqual(1, calculator.Subtract(-2, -3));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
            Assert.AreEqual(-4, calculator.Multiply(-2, 2));
            Assert.AreEqual(6, calculator.Multiply(-2, -3));
            Assert.AreEqual(0, calculator.Multiply(5, 0));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(2, calculator.Divide(6, 3));
            Assert.AreEqual(-1, calculator.Divide(-2, 2));
            Assert.AreEqual(1, calculator.Divide(-3, -3));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            calculator.Divide(5, 0);
        }
    }
}
