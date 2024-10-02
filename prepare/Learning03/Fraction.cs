using System;

public class Fraction
{
    //private attributes of the top & bottom of the fraction
    private int _top;
    private int _bottom;

    /* constructors 
    1. Constructor with no parameters - (1/1)*/
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    /* 2. Constructor with parameter 
    top/1 */
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    /* 3. Constructor with two parameters 
    top/bottom*/
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    //getters & setters
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;    
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    //Method to return the fraction as string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    //method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}