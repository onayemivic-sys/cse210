using System;

public class Fraction
{
    // private attributes
    private int _top;
    private int _bottom;

    // default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // constructor with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // constructor with two parameters
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("The denominator cannot be zero.");
        }

        _top = top;
        _bottom = bottom;
    }

    // getter for top number
    public int GetTop()
    {
        return _top;
    }

    // setter for top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // getter for bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // setter for bottom number
    public void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("The denominator cannot be zero.");
        }

        _bottom = bottom;
    }
// return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    // return the fraction as a decimal
    public double GetDecimalValue()
    {
        return(double)_top / _bottom;
    }
}