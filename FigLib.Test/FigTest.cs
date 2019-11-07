using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigLib.Test
{
    [TestClass]
    public class FigTest
    {
        [TestMethod]
        public void TestCalcCircleArea()
        {
            double r = 7.62f;
            var actual = Fig.CalcCircleArea(r);
            var expected = 182.41;

            Assert.AreEqual(Math.Round(actual, 2), expected);
        }

        [TestMethod]
        public void TestCalcTriangleArea()
        {
            double a = 5;
            double b = 4;
            double c = 3;

            var actual = Fig.CalcTriangleArea(a, b, c);
            var expected = 6;

            Assert.AreEqual(actual, expected);
        }
    }
}
