using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxTest;
using System;

namespace LibraryTesting
{
    [TestClass]
    public class UnitTestForTriangle
    {
        [TestMethod]
        public void TestCreateInstanceTriangle()
        {
            double aSide = 10;
            double bSide = 10;
            double cSide = 10;

            var actual = new Triangle(aSide, bSide, cSide);

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestNotCreateInstanceTriangle()
        {
            double aSide = 35;
            double bSide = 20;
            double cSide = 10;

            Assert.ThrowsException<ArgumentException>(() => new Triangle(aSide, bSide, cSide));
        }

        [TestMethod]
        public void TestCorrectlySumAreaTriangle()
        {
            double aSide = 10;
            double bSide = 12;
            double cSide = 10;
            var triangle = new Triangle(aSide, bSide, cSide);
            double delta = 0.01;

            double expected = 48;
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestCorrectlySumAreaTriangleWithFloatingPointNumber()
        {
            double aSide = 10.1;
            double bSide = 12.2;
            double cSide = 10;
            var triangle = new Triangle(aSide, bSide, cSide);
            double delta = 0.01;

            double expected = 48.71919;
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestTriangleIsRectangular()
        {
            double aSide = 3;
            double bSide = 4;
            double cSide = 5;
            var triangle = new Triangle(aSide, bSide, cSide);

            bool actual = triangle.IsTriangleRectangular();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestTriangleIsNotRectangular()
        {
            double aSide = 4;
            double bSide = 4;
            double cSide = 5;
            var triangle = new Triangle(aSide, bSide, cSide);

            var actual = triangle.IsTriangleRectangular();

            Assert.IsFalse(actual);
        }
    }
}
