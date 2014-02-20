namespace ShapeClass
{
    using System;
    class Test
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(5, 6),
                new Rectangle(5, 6),
                new Circle(5),
                new Triangle(8.12, 5.4),
                new Rectangle(2.4, 7.3),
                new Circle(5.5)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("The surface of the {0} is {1:0.00}sm",shape.GetType().Name , shape.CalculateSurface());
            }
        }
    }
}
