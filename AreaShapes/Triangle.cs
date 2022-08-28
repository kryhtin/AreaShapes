using System;
using System.Reflection.Metadata;

namespace AreaShapes
{
    public class Triangle : Shape, ITriangle
    {
        public ulong A;
        public ulong B;
        public ulong C;

        public Triangle(ulong a, ulong b, ulong c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override double Square
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