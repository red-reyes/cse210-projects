public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle (string shape, string color, double length, double width) : base (shape, color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}