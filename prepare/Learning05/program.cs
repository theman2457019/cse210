using System;

class Program
{
    static void Main(string[] args)
    {
       // Shape shape = new Square("Red", 5);
       // Console.WriteLine("Color of the square is: " + shape.Color);
       // Console.WriteLine("Area of the square is: " + shape.GetArea());

        // shape = new Rectangle("Blue", 5, 10); 
        // Console.WriteLine("Color of the rectangle is: " + shape.Color);
        // Console.WriteLine("Area of the rectangle is: " + shape.GetArea());

        // shape = new Circle("Green", 5);
        // Console.WriteLine("Color of the circle is: " + shape.Color);
        // Console.WriteLine("Area of the circle is: " + shape.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 5, 10));
        shapes.Add(new Circle("Green", 5));

        foreach (Shape shape in shapes)
        {
            string shapeType = shape.GetType().Name;
            Console.WriteLine($"Color of the {shapeType} is: " + shape.Color);
            Console.WriteLine($"Area of the {shapeType} is: " + shape.GetArea());
        }
    }
}