namespace GeometryApp.ShapesTest;

using ShapesLib;
[TestClass]
public class SquareTests
{
    
    [TestMethod]
    public void TestArea()
    {
        Square square = new Square(5);
       
        var result = square.CalculateArear();

        
        var result2 = square.CalculatePerimeter();

        
        Assert.AreEqual(25, result);
        Assert.AreEqual(20, result2);
    }
}