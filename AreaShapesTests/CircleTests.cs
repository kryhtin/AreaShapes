using AreaShapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaShapesTests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void Area_ZeroRadius_ThrowException()
    {
        double radius = 0;

        Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
    }

    [TestMethod]
    public void Area_NegativeRadius_ThrowException()
    {
        double radius = -2;

        Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
    }

    [TestMethod]
    public void Area_PositiveRadius_ReturnsValue()
    {
        double radius = 2;

        var circleShape = new Circle(radius);

        Assert.AreEqual(12.566370614359172, circleShape.Area);
    }
}