using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ShapeTests
{
    [TestMethod]
    public void TestCircleArea()
    {
        Circle circle = new Circle(5);
        double expectedArea = Math.PI * 5 * 5;
        double actualArea = circle.GetArea();
        Assert.AreEqual(expectedArea, actualArea, 0.0001);
    }

    [TestMethod]
    public void TestTriangleArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        double actualArea = triangle.GetArea();
        Assert.AreEqual(expectedArea, actualArea, 0.0001);
    }

    [TestMethod]
    public void TestRightAngledTriangle()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        bool isRightAngled = triangle.IsRightAngledTriangle();
        Assert.IsTrue(isRightAngled);
    }
}
