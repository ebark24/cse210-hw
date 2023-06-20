using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();

        Square Square = new Square("Blue",5);
        Shapes.Add(Square);
        Circle Circle = new Circle("Green", 4);
        Shapes.Add(Circle);
        Rectangle Rectangle = new Rectangle("Red", 10, 5);
        Shapes.Add(Rectangle);

        foreach (Shape shape in Shapes)
            {
                Console.WriteLine($"The color is {shape.GetColor()} and the area is {shape.GetArea()}");
            }
    }
}