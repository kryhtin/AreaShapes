using System;

namespace AreaShapes
{
    public abstract class Shape : IShape
    {
        public abstract double Area { get; }
    }
}