﻿using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            int a = 3;
            int b = 5;
            int expected = 15;
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RectangleAreaInvalidDataTest1()
        {
            bool catched = false;
            try
            {
                int a = -4;
                int b = 10;
                Geometry g = new Geometry();
                g.RectangleArea(a, b);
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны недопустимые данные");
        }

        [TestMethod]
        public void RectangleAreaInvalidDataTest2()
        {
            int a = -4;
            int b = 10;
            Geometry g = new Geometry();
            Assert.ThrowsException<ArgumentException>(() => g.RectangleArea(a, b),
                "не обработаны отрицательные длины сторон прямоугольника");
        }
    }
}
