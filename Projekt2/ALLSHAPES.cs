using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektarbeteSENASTE
{
    interface Allshapes
    {



    }

    class polygom : Allshapes
    {

        //lista av alla hörn i poly kommer behövas
        // point ska vara en egen klass ( kan också användas xypointscore ) 

        int sides;
        List<X_Y_PointScore> CornerList = new List<X_Y_PointScore>();
        double radius;
        double sideLenght;

        public Polygom(string s, int x, int y, int p, int sides) : base(s, x, y, p)
        {
            this.sides = sides;
            sideLenght = p / sides;
            radius = SetRadius();
            CornerList = GetCornerList();
        }

        public double SetRadius()
        {
            return sideLenght / (2 * Math.Sin(Math.PI / sides));
        }

        public List<X_Y_PointScore> GetCornerList()
        {
            List<X_Y_PointScore> outList = new List<X_Y_PointScore>();
            var angle = Math.PI * 2 / sides;
            double offset = (sides % 2 == 0) ? (angle / 2) : 0;
            double xCoord = 0;
            double yCoord = 0;

            var D = new SHAPE_X_Y_PERIMETER(); // wtf is going on


            for (int i = 0; i < sides; i++)
            {
                xCoord = D.X + (radius + Math.Sin(i * angle + offset));
                yCoord = D.Y + (radius + Math.Cos(i * angle + offset));

                outList.Add(new Point(xCoord, yCoord));
            }
            return outList;
        }

        public double CalcArea()
        {
            var apo = 0.5 * sideLenght * (1 / Math.Tan(Math.PI / sides));
            return (sides * sideLenght * apo) / 2;
        }

    }

    class cirkel : Allshapes
    {



    }

}
