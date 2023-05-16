public class fraction
{
    private int _top;
    private int _bottom;

    public fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

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

    public string GetFraction()
    {
        string top_string = _top.ToString();
        string bottom_sting = _bottom.ToString();
        string fraction = $"{_top}/{_bottom}";
        return fraction;

    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}