using System;

namespace AreaShapes
{
    public class Circle : Shape
    {
        readonly double radius;

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException();
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
    }
}