using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WiproNGATraningDay8; // Import the namespace containing TestingClass

namespace TestProject1
{
    [TestClass]
    public class Test1
    {
        private TestingClass _calculator;

        // This method runs before each test case
        [TestInitialize]
        public void Setup()
        {
            _calculator = new TestingClass();
        }

        [TestMethod]
        public void TestAddition()
        {
            // Arrange
            int a = 10, b = 5;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(15, result, "Addition Test Failed");
        }

        [TestMethod]
        public void TestSubtraction()
        {
            int a = 10, b = 5;
            int result = _calculator.Subtract(a, b);
            Assert.AreEqual(5, result, "Subtraction Test Failed");
        }

        [TestMethod]
        public void TestMultiplication()
        {
            int a = 10, b = 5;
            int result = _calculator.Multiply(a, b);
            Assert.AreEqual(50, result, "Multiplication Test Failed");
        }

        [TestMethod]
        public void TestDivision()
        {
            int a = 10, b = 5;
            double result = _calculator.Divide(a, b);
            Assert.AreEqual(2, result, "Division Test Failed");
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            int a = 10, b = 0;
            double result = _calculator.Divide(a, b);
            Assert.AreEqual(double.NaN, result, "Division by Zero Test Failed");
        }

        [TestMethod]
        public void TestModulus()
        {
            int a = 10, b = 3;
            int result = _calculator.Modulus(a, b);
            Assert.AreEqual(1, result, "Modulus Test Failed");
        }

        [TestMethod]
        public void TestModulusByZero()
        {
            int a = 10, b = 0;
            int result = _calculator.Modulus(a, b);
            Assert.AreEqual(0, result, "Modulus by Zero Test Failed");
        }
    }
}
