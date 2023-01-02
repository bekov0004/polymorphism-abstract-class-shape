public abstract class Shape
{
    protected Enum Color;
    protected bool Filled = true;
    public Shape()
    {}
    public Shape(Enum color, bool filled)
    {
        Color = color;
        Filled = filled;
    }
    public Enum GetColor()
    {
        return Color;
    }
    public void SetColor(Enum color)
    {
        Color = color;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public virtual string ToString()
    {
        return $"Shape color={Color} filled={Filled}";
    }

}