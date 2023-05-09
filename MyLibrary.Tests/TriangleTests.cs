using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MyLibrary;

namespace MyLibraryTest
{
    [TestClass]
    public class TriangleTests
    {
        [DataTestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(-2, 2, 2, 0)]
        [DataRow(3, 0, 3, 0)]
        [DataRow(4, 4, -4, 0)]
        [DataRow(1, 1, 10, 0)]
        [DataRow(4, 10, 6, 0)]
        [DataRow(3, 3, 9, 0)]
        public void GetSquare_FromDataRowTest(double firstSide, double secondSide,
            double thirdSide, double expected)
        {
            // arrange
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            // act
            double actual = triangle.GetSquare();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightTriangle_3and4and5_ReturnedTrue()
        {
            // arrange
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            bool expected = true;

            // act
            bool actual = triangle.IsRightTriangle();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
