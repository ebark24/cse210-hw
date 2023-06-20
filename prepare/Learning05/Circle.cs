public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    {
        _radius = radius;
        SetColor(color);
    }

    public override double GetArea()
    {
        double area = 3.14 * (_radius * _radius);
        return area;
    }

}