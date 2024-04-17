namespace ShapesLib;
using GeometryApp.ShapesLib.Interfaces;

public class Triangle : IShape
{
    private double baseOfTriangle;
    private double height;

    public Triangle(double baseOfTriangle, double height){
        this.baseOfTriangle = baseOfTriangle;
        this.height = height;    
    }

    public double CalculateArea()
    {
        throw new NotImplementedException();
    }

    public double CalculateArear(){
        return (baseOfTriangle * height) * 0.5;
    }

    public double CalculatePerimeter(){
        double halfBase = 0.5 * baseOfTriangle;
        double hypotenuse = Math.Sqrt(Math.Pow(halfBase, 2) + Math.Pow(height, 2));
        return baseOfTriangle + hypotenuse + hypotenuse;
    }
}
