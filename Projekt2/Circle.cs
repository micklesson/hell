using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt2
{
    public class Circle : IShape
    {
        private int perimeter;
        Coordinate center;

        public Circle(Coordinate center, int _perimeter)
        {
            this.center = center;
            perimeter = _perimeter;
        }
        public double GetRadius()
        {
            return perimeter / (2 * Math.PI);
        }
        public double GetDistance(Coordinate c)
        {
            return Math.Sqrt(Math.Pow(c.X - center.X, 2) + Math.Pow(c.Y - center.Y, 2));
        }
        public double GetArea()
        {
            double radius = GetRadius();
            return radius * radius * Math.PI;
        }

        public bool IsInside(Coordinate c)
        {
            return GetDistance(c) <= GetRadius();
        }
    }
}
