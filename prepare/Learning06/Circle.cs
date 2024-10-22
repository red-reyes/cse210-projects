public class Circle : Shape
{
    private double _radius;

    public Circle (string shape, string color, double radius) : base (shape, color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}