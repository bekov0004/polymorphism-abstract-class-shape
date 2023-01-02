public class Square : Ractange
{
    public double Side { get; set; } = 1.0;
    public Square()
    {
        
    }
    public Square(double side)
    {
        Side = side;
    }
    public Square(double side, Enum color, bool filled)
    {
         Side = side;
    }
    public double GetSide()
    {
        return Side;
    }
    public  void SetWidth(double side)
    {
        _width = side;
    }
    
    public  void SetLength(double side)
    {
        _length = side;
    }
    public override string ToString()
    {
        return $"Squre {base.ToString()}";
    }

}