using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void TestCircleArea()
        {
            double radius = 5;
            double expected = Math.PI * radius * radius;

            double actual = testTaskMindbox.GeometryLibrary.CircleArea(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleAreaWithNegativeRadius()
        {
            double radius = -5;

            Geometry.CircleArea(radius);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double expected = 6;

            double actual = Geometry.TriangleArea(side1, side2, side3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleAreaWithNegativeSides()
        {
            double side1 = -3;
            double side2 = 4;
            double side3 = 5;

            Geometry.TriangleArea(side1, side2, side3);
        }

        [TestMethod]
        public void TestIsRightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            bool actual = Geometry.IsRightTriangle(side1, side2, side3);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestIsNotRightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 6;

            bool actual = Geometry.IsRightTriangle(side1, side2, side3);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCalculateCircleArea()
        {
            Geometry.Circle circle = new Geometry.Circle(5);
            double expected = Math.PI * circle.Radius * circle.Radius;

            double actual = Geometry.CalculateArea(circle);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            Geometry.Triangle triangle = new Geometry.Triangle(3, 4, 5);
            double expected = 6;

            double actual = Geometry.CalculateArea(triangle);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCalculateAreaWithUnsupportedShape()
        {
            object shape = new object();

            Geometry.CalculateArea(shape);
        }

        [TestMethod]
        public void TestCircleAreaUsingIShape()
        {
            Geometry.IShape circle = new Geometry.Circle(5);
            double expected = Math.PI * ((Geometry.Circle)circle).Radius * ((Geometry.Circle)circle).Radius;

            double actual = circle.Area();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangleAreaUsingIShape()
        {
            Geometry.IShape triangle = new Geometry.Triangle(3, 4, 5);
            double expected = 6;

            double actual = triangle.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}
