public class Square : Shape
{
    private double _side;

    public Square(string Color, double Side)
    {
        _side = Side;
        SetColor(Color);
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}