using System;

public class Fraction
{
    private int _top;
    private int _bottom;



    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator1)
    {
        _top = numerator1;
        _bottom = 1;
    }

    public Fraction(int numerator, int denom)
    {
        _top = numerator;
        _bottom = denom;
    }
    public int GetNumerator()
    {
        return _top;    
    }

    public void SetNumerator(int numerator)
    {
        _top = numerator;
    }

    public int GetDenom()
    {
        return _bottom; 
    }

    public void SetDenom(int denom)
    {
        _bottom = denom;
    }
    

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }



}