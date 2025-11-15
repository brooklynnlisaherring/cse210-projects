using System.Data;

public class Fractions
{
    //Attributes
    private int _top;
    private int _bottom;

    //Constructors
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fractions(int top)
    {
        _top = top;
        _bottom = 1; 
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    // Getters and setters 
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

    public string GetFractionString(int top, int bottom)
    {
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue(int top, int bottom)
    {
        double decimalValue = top / bottom;

        return decimalValue;
    }


}