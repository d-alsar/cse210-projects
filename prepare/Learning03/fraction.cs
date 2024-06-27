using System;

public class Fraction
{
    private int _top; //Atribute for top
    private int _bottom; //Atribute for bottom

    public Fraction() //Constructor has no parameters and initializes the number to 1/1.

    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) //Constructor that has one parameter for the top and that initializes the denominator to 1
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) //Constructor that has two parameters, one for the top and one for the bottom.
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}