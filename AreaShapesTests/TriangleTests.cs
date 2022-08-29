using AreaShapes;
namespace AreaShapesTests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Area_ZeroSides_ThrowException()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 0, 0));
    }

    [TestMethod]
    public void Area_NegativeSides_ThrowException()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 4, -5));
    }

    [TestMethod]
    public void Area_PositiveSides_ReturnsValue()
    {
        var triangleShape = new Triangle(7, 10, 12);

        Assert.AreEqual(34.977671449083054, triangleShape.Area);
    }

    [TestMethod]
    public void IsRight_RightTriangle_ReturnsTrue()
    {
        var triangleShape = new Triangle(3, 4, 5);

        Assert.IsTrue(triangleShape.IsRight());
    }

    [TestMethod]
    public void IsRight_NotRightTriangle_ReturnsFalse()
    {
        var triangleShape = new Triangle(3, 5, 5);

        Assert.IsFalse(triangleShape.IsRight());
    }
}