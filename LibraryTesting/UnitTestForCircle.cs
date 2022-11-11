using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTest;
using System;

namespace LibraryTesting
{
    [TestClass]
    public class UnitTestForCircle
    {
        [TestMethod]
        public void TestCreateInstanceCircle()
        {
            double radius = 10;

            var actual = new Circle(radius);

            Assert.IsNotNull(actual);
        }
        
        [TestMethod]
        public void TestNotCreateInstanceCircle()
        {
            double radius = 0;

            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }

        [TestMethod]
        public void TestCorrectlySumAreaCircle()
        {
            double radius = 10;
            var circle = new Circle(radius);
            double delta = 0.01;

            double expected = 314.15;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestCorrectlySumAreaCircleWithFloatingPointNumber()
        {
            var circle = new Circle(3.14);
            var delta = 0.01;

            double expected = 30.974;
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual, delta);
        }
    }
}