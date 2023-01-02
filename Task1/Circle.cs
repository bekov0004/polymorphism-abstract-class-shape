public class Circle
{
    public double Radius { get; set; }
    public double PI { get; set; }
    public Circle()
    {
        
    }
    public Circle(double radius)
    {  
       Radius = radius;
    }
    public double GetRadius()
    {
        return Radius;
    }
    public void SetRadius(double radius)
    {
        Radius = radius;
    }
    public void GetArea()
    {
        System.Console.WriteLine(PI*Radius*Radius);
    }
    public double GetCircumFerence()
    {
        return 2*PI*Radius;
    }
    public override string ToString()
    {
        return $"Circle radius =  {Radius}"; 
    }


}