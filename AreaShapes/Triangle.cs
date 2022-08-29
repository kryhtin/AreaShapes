using System;
using System.Reflection.Metadata;

namespace AreaShapes
{
    public class Triangle : Shape, ITriangle
    {
        public double A;
        public double B;
        public double C;

        public Triangle(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0)) throw new ArgumentException();
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override double Area
        {
            get
            {
                var semiPerimeter = (A + B + C) / 2;
                return Math.Sqrt(semiPerimeter
                    * ((semiPerimeter - A)
                    * (semiPerimeter - B)
                    * (semiPerimeter - C)));
            }
        }

        public bool IsRight()
        {
            return ((A * A == B * B + C * C)
                || (B * B == A * A + C * C)
                || (C * C == A * A + B * B));
        }
    }
}