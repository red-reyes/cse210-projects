/*
In a new file, create the Shape class.
Add the color member variable and a getter and setter for it.
Create a constructor that accepts the color and set its.
Create a virtual method for GetArea().
*/
using System;

public abstract class Shape
{
    protected string _shape;
    protected string _color;

    public Shape(string shape, string color)
    {
        _shape = shape;
        _color = color;
    }

    public string GetShape()
    {
        return _shape;
    }
    public void SetShape(string shape)
    {
        _shape = shape;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public abstract double GetArea();

}