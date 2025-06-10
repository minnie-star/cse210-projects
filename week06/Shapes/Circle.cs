using System.Diagnostics.CodeAnalysis;

public class Circle : Shapes
{
    private double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}