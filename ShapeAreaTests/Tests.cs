using AreaCalculator;

namespace ShapeAreaTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CircleTest1()
        {
            double r = 3;
            var circle = new Circle(r);
            Assert.AreEqual(Math.PI * r * r, circle.Area, 0.001);
        }

        [TestMethod]
        public void CircleTest2()
        {
            double r = 120;
            var circle = new Circle(r);
            Assert.AreEqual(Math.PI * r * r, circle.Area, 0.001);
        }

        [TestMethod]
        public void TriangleTest1()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(6, triangle.Area, 0.001);
        }

        [TestMethod]
        public void TriangleTest2()
        {
            double a = 80;
            double b = 100;
            double c = 160;
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(3272.613634, triangle.Area, 0.001);
        }

        [TestMethod]
        public void TriangleTest3()
        {
            double a = 0.1;
            double b = 0.1;
            double c = 0.15;
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(0.0049608, triangle.Area, 0.001);
        }

        [TestMethod]
        public void TriangleTest4()
        {
            double a = 50;
            double b = 70;
            double c = 120;
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(0, triangle.Area, 0.001);
        }

        [TestMethod]
        public void EllipseTest1()
        {
            double a = 10;
            double b = 15;
            var ellipse = new Ellipse(a, b);
            Assert.AreEqual(471.23889, ellipse.Area, 0.001);
        }

        [TestMethod]
        public void EllipseTest2()
        {
            double a = 0.1;
            double b = 1000;
            var ellipse = new Ellipse(a, b);
            Assert.AreEqual(314.15926535, ellipse.Area, 0.001);
        }

        [TestMethod]
        public void ShapeInCircleTest1()
        {
            double r = 30;
            var figure = new Figure(r);
            Assert.AreEqual(Math.PI * r * r, figure.Area, 0.001);
        }

        [TestMethod]
        public void ShapeInTriangleTest1()
        {
            double a = 6;
            double b = 7;
            double c = 9;
            var figure = new Figure(a, b, c);
            Assert.AreEqual(20.9761769, figure.Area, 0.001);
        }

        [TestMethod]
        public void ShapeInEllipseTest1()
        {
            double a = 2;
            double b = 4;
            var figure = new Figure(a, b);
            Assert.AreEqual(25.13274, figure.Area, 0.001);
        }

        [TestMethod]
        public void ChangeParameterTest1()
        {
            double r = 5;
            var circle = new Circle(r);
            Assert.AreEqual(Math.PI * r * r, circle.Area, 0.001);
            r = 9;
            circle.Radius = r;
            Assert.AreEqual(Math.PI * r * r, circle.Area, 0.001);
        }

        [TestMethod]
        public void ChangeParameterTest2()
        {
            double a = 5;
            double b = 7;
            var ellipse = new Ellipse(a, b);
            Assert.AreEqual(109.95574, ellipse.Area, 0.001);
            a = 9;
            b = 3;
            ellipse.FirstHalfAxis = a;
            ellipse.SecondHalfAxis = b;
            Assert.AreEqual(84.823001, ellipse.Area, 0.001);
        }

        [TestMethod]
        public void ChangeParameterTest3()
        {
            double a = 6;
            double b = 7;
            double c = 8;
            var triangle = new Triangle(a, b, c);
            Assert.AreEqual(20.333162, triangle.Area, 0.001);
            a = 1;
            b = 9;
            c = 9.3;
            triangle.A = a;
            triangle.B = b;
            triangle.C = c;
            Assert.AreEqual(4.3577509, triangle.Area, 0.001);
        }

        [TestMethod]
        public void ZeroValueTest()
        {
            double r = 0;
            var circle = new Circle(r);
            Assert.AreEqual(0, circle.Area, 0.001);
        }

        [TestMethod]
        public void NegativeValueTest1()
        {
            double r = -10;
            try
            {
                var circle = new Circle(r);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void NegativeValueTest2()
        {
            double a = 10;
            double b = -30;
            try
            {
                var ellipse = new Ellipse(a, b);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void NegativeValueTest3()
        {
            double a = 10;
            double b = -5;
            double c = 20;
            try
            {
                var triangle = new Triangle(a, b, c);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void NegativeValueTest4()
        {
            double a = 10;
            double b = -5;
            double c = 20;
            try
            {
                var figure = new Figure(a, b, c);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void WrongTriangleSidesTest()
        {
            double a = 10;
            double b = 60;
            double c = 20;
            try
            {
                var figure = new Figure(a, b, c);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
        }
    }
}