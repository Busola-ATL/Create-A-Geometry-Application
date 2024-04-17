namespace GeometryApp.ShapesLib;
using GeometryApp.ShapesLib.Interfaces;

public class Square : IShape
{
    private double lenght;

    public Square(double lenght){
        this.lenght = lenght;
        
    }

    public double CalculateArea()
    {
        throw new NotImplementedException();
    }

    public double CalculateArear(){
        return Math.Pow(lenght, 2);
    }

    public double CalculatePerimeter(){
        return 2 * (lenght + lenght);
    }

}
