using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square();
        square.SetColor("pink");
        square.SetSide(6);
        Console.WriteLine(square.GetArea());


        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("orange");
        rectangle.SetWidth(4);
        rectangle.SetLenght(8);
        rectangle.GetArea();
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle();
        circle.SetColor("yellow");
        circle.SetRadius(7);
        Console.WriteLine(circle.GetArea());

        List<Shapes> shapes = new List<Shapes> { square, rectangle, circle };
        foreach (var shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has the area of {area}.");
        }
    }
}