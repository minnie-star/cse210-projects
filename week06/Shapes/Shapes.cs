using System.Drawing;

public class Shapes
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        // Base class does not know how to calculate area
        return 0;
    }
}