using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MyLibrary;

namespace MyLibraryTest
{
    [TestClass]
    public class CircleTests
    {
        [DataTestMethod]
        [DataRow(10, 314)]
        [DataRow(-2, 0)]
        [DataRow(0, 0)]
        public void GetSquare_FromDataRowTest(double radius, double expected)
        {
            // arrange
            Circle circle = new Circle(radius);

            // act
            double actual = circle.GetSquare();

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
