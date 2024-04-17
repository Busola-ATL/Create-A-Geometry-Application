namespace GeometryApp.ShapesTest;

using ShapesLib;

[TestClass]
public class RectangleTest
{
    [TestMethod]
    public void TestArea()
    {
        Rectangle rect = new Rectangle(4, 5);

        
        var result = rect.CalculateArear();

        
       var result1 = rect.CalculatePerimeter();

        //Assert
        Assert.AreEqual(20, result);
        Assert.AreEqual(18, result1);
    }
}