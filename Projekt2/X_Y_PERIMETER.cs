using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektarbeteSENASTE
{
    class SHAPE_X_Y_PERIMETER
    {

        public string shape;
        public double X;
        public double Y;
        public double omkrets;

        public SHAPE_X_Y_PERIMETER(string _shape, double _x, double _y, double _omkrets)
        {

            shape = _shape;
            X = _x;
            Y = _y;
            omkrets = _omkrets;

        }

    }
}
