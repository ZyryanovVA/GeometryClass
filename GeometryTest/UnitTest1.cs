using GeometryClass;


namespace GeometryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircle()
        {

            double radius = 5;
            double expected = 78.54;
            double result = Math.Round(Circle.CSquare(radius), 2);           
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestSTriangle()
        {

            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            double result = Triangle.TSquare(a, b, c);          
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestRTriangle()
        {

            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            bool result = Triangle.TRight(a, b, c);
            Assert.AreEqual(expected, result);
        }

    }
}