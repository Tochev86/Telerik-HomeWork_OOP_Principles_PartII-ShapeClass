namespace ShapeClass
{
    public class Triangle : Shape
    {
        public Triangle(double high, double width)
        {
            this.High = high;
            this.Width = width;
        }
        public override double CalculateSurface()
        {
            return (base.CalculateSurface() / 2);
        }
    }
}
