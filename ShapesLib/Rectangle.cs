namespace GeometryApp.ShapesLib;
using Interfaces;

public class Rectangle : IShape
{
    private double lenght;
    private double breadth;

    public Rectangle(double lenght, double breadth){
        this.lenght = lenght;
        this.breadth = breadth; 
    }

    public double CalculateArea()
    {
        throw new NotImplementedException();
    }

    public double CalculateArear(){
        return lenght * breadth;
    }

    public double CalculatePerimeter(){
        return 2 * (lenght + breadth);
    }
}
