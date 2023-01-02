using System;
 public class Ractange : Shape
{
    protected double _width  = 1.0;
    protected double _length  = 1.0;
    public Ractange()
    {
        
    }
    public Ractange(double width, double height)
    {
        _width = width;
        _length = height;
    }
    public Ractange(double width, double height,Enum color, bool filled)
    :base(color,filled)
    {
         _width = width;
        _length = height;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public override double GetArea()
    {
        return _width*_length;
    }
    public override double GetPerimeter()
    {
        return 2*(_width+_length);
    }
    public override string ToString()
    {
        return $"Rectangle{base.ToString()}  Width={_width} Length={_length}";
    }


}