
using GeometryApp.ShapesLib;
using ShapesLib;
namespace GeometryApp.ShapesTest;



[TestClass]
public class TriangleTest
{
    [TestMethod]
    public void TestArea()
    {
        Triangle triangle = new Triangle(8, 3);

        //calling area method
        var result = triangle.CalculateArear();

        //calling square method
       var result1 = triangle.CalculatePerimeter();

        //Assert
        Assert.AreEqual(12, result);
        Assert.AreEqual(18, result1);
    }
}