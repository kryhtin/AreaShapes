using AreaShapes;
namespace AreaShapesTests;

[TestClass]
public class ShapeTests
{
    [TestMethod]
    public void Area_CreateCircleShape_ReturnsValue()
    {
        Shape shape = new Circle(3);

        Assert.AreEqual(28.274333882308138, shape.Area);
    }

    [TestMethod]
    public void Area_CreateTriangleShape_ReturnsValue()
    {
        Shape shape = new Triangle(3, 4, 5);

        Assert.AreEqual(6, shape.Area);
    }
}