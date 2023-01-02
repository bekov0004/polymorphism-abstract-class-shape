public class Circle : Shape
{
    private double _radius = 1.0;
        public Circle()
        {

        }
        public Circle(double radius)
        {
            _radius = radius;
        }
        public Circle(double radius,Enum color, bool filled)  
        :base(color,filled)
        {
            _radius = radius;
        }
        public double GetRadius()
        {
            return _radius;
        }
        public override double GetArea()
        {
            return 3.14 * _radius * _radius;
        }
        public override double GetPerimeter()
        {
            return 2*3.14*_radius;
        }
        public override string ToString()
        {
            return $"Circle {base.ToString()} Radius={_radius}";
        }
}