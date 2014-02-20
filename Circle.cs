namespace ShapeClass
{
    using System;
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Width = radius;
            this.High = radius;
        }
        public override double CalculateSurface()
        {
            return (Math.PI * base.CalculateSurface());
        }
    }
}
