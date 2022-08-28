using System;

namespace AreaShapes
{
    public class Circle : Shape
    {
        readonly ulong radius;

        public Circle(ulong radius)
        {
            this.radius = radius;
        }

        public override double Square
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
    }
}