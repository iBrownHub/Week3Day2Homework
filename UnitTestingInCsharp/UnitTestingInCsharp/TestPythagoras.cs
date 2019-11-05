using System;
using NUnit.Framework;

namespace UnitTestingInCsharp
{
    [TestFixture]
    public class TestPythagoras
    {
        [TestCase(5,4,3)]
        public void TestPythagorasMethod(int a, int b, int c)
        {
            Assert.AreEqual((a * a), ((b * b) + (c * c)));
        }
    }
}
