using System;
public class Square : Shape
{
    private double _side;

    public Square (string shape, string color, double side) : base (shape, color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }


}