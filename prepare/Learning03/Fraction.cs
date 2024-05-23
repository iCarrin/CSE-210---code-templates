using System.Dynamic;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction ()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction (int numeratior)
    {
        _top = numeratior;
        _bottom = 1;
    }
    public Fraction (int numeratior, int denominator)
    {
        _top = numeratior;
        _bottom = denominator;
    }

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int numerator)
    {
        _top = numerator;
    }
    public void SetBottom(int denominator)
    {
        _bottom = denominator;
    }

    public string GetFractionString()
    {
        return ($"{_top}/{_bottom}");
    }
    public double GetDecimalValue()
    {
        return((double)_top / (double)_bottom);
    }
}