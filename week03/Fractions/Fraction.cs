using System.Security.Principal;

public class Fraction
{
    private int _topNumber;

    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public int GetNumerator()
    {
        return _topNumber;
    }

    public void SetNumerator()
    {
        int newTopNumber = _topNumber;
        _topNumber = newTopNumber;
        return;
    }

    public int GetDenominator()
    {
        return _bottomNumber;
    }

    public void SetDenominator()
    {
        int _newBottomNumber = _bottomNumber;
        _bottomNumber = _newBottomNumber;
        return;
    }

    public string GetFractionString()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }
}