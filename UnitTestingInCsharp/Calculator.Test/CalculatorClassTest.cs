using System;
using NUnit.Framework;

namespace Calculator.Test
{
    
    [TestFixture]
    public class CalculatorClassTest
    {
        CalculatorClass calc = new CalculatorClass();
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(14, calc.Add(9, 5));
        }
        [Test]
        public void TestSubtract()
        {
            Assert.AreEqual(1, calc.Subtract(5, 4));
        }
        [Test]
        public void TestMultiply()
        {
            Assert.AreEqual(24, calc.Multiply(6, 4));
        }
        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(3, calc.Divide(6, 2));
        }
        [Test]
        public void TestNotAdd()
        {
            Assert.AreNotEqual(143, calc.Add(9, 5));
        }
        [Test]
        public void TestNotSubtract()
        {
            Assert.AreNotEqual(145, calc.Subtract(5, 4));
        }
        [Test]
        public void TestNotMultiply()
        {
            Assert.AreNotEqual(2, calc.Multiply(6, 4));
        }
        [Test]
        public void TestNotDivide()
        {
            Assert.AreNotEqual(4, calc.Divide(6, 2));
        }
        [Test]
        public void TestSquare()
        {
            Assert.AreEqual(169, calc.Square(13));
        }
        [Test]
        public void TestSquareRoot()
        {
            Assert.AreEqual(15, calc.SquareRoot(225));
        }
        [Test]
        public void TestNotSquare()
        {
            Assert.AreNotEqual(163, calc.Square(13));
        }
        [Test]
        public void TestNotSquareRoot()
        {
            Assert.AreNotEqual(13, calc.SquareRoot(225));
        }
    }
}
