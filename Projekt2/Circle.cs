using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt2
{
    public class Circle : IShape
    {
        private int perimeter;
        X_Y_PointScore center;

        public Circle(double x, double y, double _perimeter)
        {
            X_Y_PointScore temp = new X_Y_PointScore(x,y,0);
            center = temp;
            perimeter = _perimeter;
        }
        public double GetRadius()
        {
            return perimeter / (2 * Math.PI);
        }
        public double GetDistance(X_Y_PointScore point)
        {
            return Math.Sqrt(Math.Pow(point.X - center.X, 2) + Math.Pow(point.Y - center.Y, 2));
        }
        public double GetArea()
        {
            double radius = GetRadius();
            return radius * radius * Math.PI;
        }

        public bool IsInside(X_Y_PointScore point)
        {
            return GetDistance(point) <= GetRadius();
        }
    }
}
